//using log4net.Core;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Modbus.Device;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Abp.Modbus
{
    /// <summary>
    /// 与PLC通讯，目前只有modbus-tcp的接口
    /// </summary>
    public class TcpModbus : ITcpModbus, ISingletonDependency
    {
        //public ILogger Logger { get; set; }
        private readonly AbpClientManager _manager;

        Dictionary<int, IPEndPoint> dic = new Dictionary<int, IPEndPoint>();
        //对每个plc 建立长连接
        public TcpModbus(AbpClientManager manager)
        {
            _manager = manager;
        }

        public void CreateClient(int plcNo, string ip, int port)
        {
            //_manager.CreateClient( plcNo, ip, port);
            dic.Add(plcNo, new IPEndPoint(IPAddress.Parse(ip), port));
        }

        //同步
        public ushort[] ReadHoldingRegisters(int plcNo, ushort startAddress, ushort numberOfPoints)
        {
            //ModbusIpMaster master = _manager.GetModbusIpMaster(plcNo);
            if (!dic.ContainsKey(plcNo))
                return null;

            IPEndPoint iPEndPoint = dic[plcNo];
            using (TcpClient client = new TcpClient(iPEndPoint.Address.ToString(), iPEndPoint.Port))
            {
                client.ReceiveTimeout = 1000;

                ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

                ushort[] uData = master.ReadHoldingRegisters(startAddress, (ushort)numberOfPoints);

                return uData;
            }
        }

        //异步读取
        public ushort[] ReadHoldingRegistersAsync(int plcNo, ushort startAddress, ushort numberOfPoints)
        {
            //ModbusIpMaster master = _manager.GetModbusIpMaster(plcNo);
            if (!dic.ContainsKey(plcNo))
                return null;

            IPEndPoint iPEndPoint = dic[plcNo];
            using (TcpClient client = new TcpClient(iPEndPoint.Address.ToString(), iPEndPoint.Port))
            {
                client.ReceiveTimeout = 1000;
                client.SendTimeout = 1000;

                ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

                Task<ushort[]> task = master.ReadHoldingRegistersAsync(startAddress, (ushort)numberOfPoints);

                ushort[] uData = task.Result;
                return uData;
            }
        }

        //同步
        public T ReadData<T>(int plcNo, ushort startAddress, ushort numberOfPoints) where T : struct
        {
            //ModbusIpMaster master = _manager.GetModbusIpMaster(plcNo);
            if (!dic.ContainsKey(plcNo))
                return default(T);

            IPEndPoint iPEndPoint = dic[plcNo];
            using (TcpClient client = new TcpClient(iPEndPoint.Address.ToString(), iPEndPoint.Port))
            {
                client.ReceiveTimeout = 1000;

                ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

                ushort[] uData = master.ReadHoldingRegisters(startAddress, numberOfPoints);

                T obj = (T)WordsToStruct(uData, typeof(T));

                return obj;
            }
        }


        public void WriteSingleRegister(int plcNo, ushort startAddress, ushort value)
        {
            //ModbusIpMaster master = _manager.GetModbusIpMaster(plcNo);
            IPEndPoint iPEndPoint = dic[plcNo];
            using (TcpClient client = new TcpClient(iPEndPoint.Address.ToString(), iPEndPoint.Port))
            {
                ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

                master.WriteSingleRegister(startAddress, value);
            }
        }

        public void WriteMultipleRegisters(int plcNo, ushort startAddress, ushort[] data)
        {
            //ModbusIpMaster master = _manager.GetModbusIpMaster(plcNo);
            IPEndPoint iPEndPoint = dic[plcNo];
            using (TcpClient client = new TcpClient(iPEndPoint.Address.ToString(), iPEndPoint.Port))
            {
                ModbusIpMaster master = ModbusIpMaster.CreateIp(client);
                master.WriteMultipleRegisters(startAddress, data);
            }
        }

        private object WordsToStruct(ushort[] words, Type type)
        {
            List<byte> listBytes = new List<byte>();
            foreach (ushort u in words)
            {
                listBytes.AddRange(BitConverter.GetBytes(u));
            }

            byte[] bytes = listBytes.ToArray();

            //得到结构体的大小
            int size = Marshal.SizeOf(type);
            //byte数组长度小于结构体的大小
            if (size > bytes.Length)
            {
                //返回空
                return null;
            }
            //分配结构体大小的内存空间
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            //将byte数组拷到分配好的内存空间
            Marshal.Copy(bytes, 0, structPtr, size);
            //将内存空间转换为目标结构体
            object obj = Marshal.PtrToStructure(structPtr, type);
            //释放内存空间
            Marshal.FreeHGlobal(structPtr);
            //返回结构体
            return obj;
        }

    }
}
