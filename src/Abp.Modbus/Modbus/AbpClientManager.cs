using Abp.Dependency;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using Modbus.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Modbus
{
    public class AbpClientManager : PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        //长连接，记录成功通讯的
        Dictionary<int, ModbusIpMaster> _dicModbusMasters = new Dictionary<int, ModbusIpMaster>();

        //长连接，记录失败的
        Dictionary<int, IPEndPoint> _dicNotConnected = new Dictionary<int, IPEndPoint>();
        

        //管理tcp client
        public AbpClientManager(AbpTimer timer) : base(timer)
        {
            Timer.Period = 10000;
            Timer.Start();
        }

        protected override void DoWork()
        {
            foreach (KeyValuePair<int, IPEndPoint> item in _dicNotConnected)
            {
                int plcNo = item.Key;
                string ip = item.Value.Address.ToString();
                int port = item.Value.Port;
                if(CreateClient(plcNo,ip,port) != null)
                {
                    _dicNotConnected.Remove(plcNo);
                }
            }

        }

        //使用之前创建客户端
        public ModbusIpMaster CreateClient(int plcNo, string ip, int port)
        {
            //如果已创建则直接返回
            if (_dicModbusMasters.ContainsKey(plcNo))
            {
                return _dicModbusMasters[plcNo];
            }

            try
            {
                TcpClient client = new TcpClient(ip, port) { ReceiveTimeout = 1000 };
                //client.ReceiveTimeout = 1000;
                ModbusIpMaster master = ModbusIpMaster.CreateIp(client);
                _dicModbusMasters.Add(plcNo, master);
                string message = String.Format("连接 plc {0} 成功, ip:{1}, port:{2}", plcNo, ip, port);
                Logger.Info(message);
                return master;
            }
            catch
            {
                //记录下未成功的，过一段时间再尝试连接。每分钟去取尝试连接
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                if (!_dicNotConnected.ContainsKey(plcNo))
                {
                    _dicNotConnected.Add(plcNo, iPEndPoint);
                }
                string message = String.Format("连接 plc {0} 失败,ip{1},port{2}", plcNo, ip, port);
                Logger.Info(message);
                return null;
            }

        }

        public ModbusIpMaster GetModbusIpMaster(int plcNo)
        {
            if (_dicModbusMasters.ContainsKey(plcNo))
            {
                return _dicModbusMasters[plcNo];
            }
            else
            {
                return null;
            }
        }

        public void RemoveClient()
        {

        }

        //销毁所有客户端
        public void DisposeTcpClient()
        {
            foreach (ModbusIpMaster master in _dicModbusMasters.Values)
            {
                master.Dispose();
            }
        }
    }
}
