using Modbus.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Modbus.Modbus
{
    public class ClientInfo
    {
        public ModbusIpMaster master{ get; set;}

        public IPEndPoint iPEndPoint { get; set; }

        public TcpClient tcpClient { get; set; }

        public ClientInfo(string ip, int port)
        {
            CreateClient(ip,port);
        }

        private void CreateClient(string ip,int port)
        {
            tcpClient = new TcpClient(ip, port);
            master = ModbusIpMaster.CreateIp(tcpClient);
        }

        public void Disipose()
        {

        }
    }
}
