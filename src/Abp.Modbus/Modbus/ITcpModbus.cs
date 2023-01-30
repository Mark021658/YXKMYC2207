using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.Modbus
{
    public interface ITcpModbus : ISingletonDependency
    {
        T ReadData<T>(int plcNo, ushort startAddress, ushort numberOfPoints) where T : struct;
        ushort[] ReadHoldingRegisters(int plcNo, ushort startAddress, ushort numberOfPoints);
        ushort[] ReadHoldingRegistersAsync(int plcNo, ushort startAddress, ushort numberOfPoints);
        void WriteSingleRegister(int plcNo, ushort startAddress, ushort value);
        void WriteMultipleRegisters(int plcNo, ushort startAddress, ushort[] data);
        void CreateClient(int plcNo, string ip, int port);
    }
}
