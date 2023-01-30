//using log4net.Core;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Modbus.Device;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Abp.Modbus
{
    /// <summary>
    /// 与电表通讯，目前只有一个电表
    /// </summary>
    public class SerialModbus : ISingletonDependency
    {
        Dictionary<int, ModbusIpMaster> dic = new Dictionary<int, ModbusIpMaster>(); 
        public SerialModbus()
        {
            
        }

        public void CreateClient(int plcNo, string PortName)
        {
            SerialPort _serialPort = new SerialPort()
            {
                PortName = PortName,
                Parity = Parity.None,
                BaudRate = 9600,
                StopBits = StopBits.One,
                DataBits = 8,
            };
            ModbusIpMaster master = ModbusIpMaster.CreateIp(_serialPort);

            dic.Add(plcNo, master);
        }

        //同步
        public ushort[] ReadHoldingRegisters(int plcNo, ushort startAddress, ushort numberOfPoints)
        {
            ModbusIpMaster master = dic[plcNo];
            ushort[] uData = master.ReadHoldingRegisters(startAddress, (ushort)numberOfPoints);

            return uData; 
        }

        ////异步读取
        //public ushort[] ReadHoldingRegistersAsync(int plcNo, ushort startAddress, ushort numberOfPoints)
        //{
        //    //ModbusIpMaster master = _manager.GetModbusIpMaster(plcNo);
        //    if (!dic.ContainsKey(plcNo))
        //        return null;

        //    IPEndPoint iPEndPoint = dic[plcNo];
        //    using (TcpClient client = new TcpClient(iPEndPoint.Address.ToString(), iPEndPoint.Port))
        //    {
        //        client.ReceiveTimeout = 1000;

        //        ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

        //        Task<ushort[]> task = master.ReadHoldingRegistersAsync(startAddress, (ushort)numberOfPoints);

        //        ushort[] uData = task.Result;
        //        return uData;
        //    }
        //}

        //同步
        public T ReadData<T>(int plcNo, ushort startAddress, ushort numberOfPoints) where T : struct
        {
            //ModbusIpMaster master = _manager.GetModbusIpMaster(plcNo);
            if (!dic.ContainsKey(plcNo))
                return default(T);

            ModbusIpMaster master = dic[plcNo];  

            ushort[] uData = master.ReadHoldingRegisters(startAddress, numberOfPoints);

            T obj = (T)WordsToStruct(uData, typeof(T));

            return obj; 
        }


        public void WriteSingleRegister(int plcNo, ushort startAddress, ushort value)
        {
            ModbusIpMaster master = dic[plcNo]; 
            master.WriteSingleRegister(startAddress, value);
        }

        public void WriteMultipleRegisters(int plcNo, ushort startAddress, ushort[] data)
        {
            ModbusIpMaster master = dic[plcNo];
            master.WriteMultipleRegisters(startAddress, data);
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
