using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya
{
    public class Utility
    {
        /// byte数组转结构体
        ///
        /// byte数组
        /// 结构体类型
        /// 转换后的结构体
        public static object BytesToStruct(byte[] bytes, Type type)
        {
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

        public static object WordsToStruct(ushort[] words, Type type)
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

        public static Byte[] StructToBytes(Object structure)
        {

            Int32 size = Marshal.SizeOf(structure);

            IntPtr buffer = Marshal.AllocHGlobal(size);

            try
            {

                Marshal.StructureToPtr(structure, buffer, false);

                Byte[] bytes = new Byte[size];

                Marshal.Copy(buffer, bytes, 0, size);

                return bytes;

            }

            finally
            {

                Marshal.FreeHGlobal(buffer);

            }

        }

        public static ushort[] StructToShort(Object structure)
        {

            Int32 size = Marshal.SizeOf(structure);

            IntPtr buffer = Marshal.AllocHGlobal(size);

            try
            {

                Marshal.StructureToPtr(structure, buffer, false);

                short[] shorts = new short[size / 2];

                Marshal.Copy(buffer, shorts, 0, size / 2);

                ushort[] ushorts = new ushort[size / 2];
                for (int i = 0; i < shorts.Length; i++)
                {
                    ushorts[i] = Convert.ToUInt16(shorts[i]);
                }

                return ushorts;

            }

            finally
            {

                Marshal.FreeHGlobal(buffer);

            }

        }

        public static string ConvertTimeSpanToString(TimeSpan ts)
        {
            string strTime = null;

            strTime += ts.Hours.ToString().PadLeft(2, '0') + ":";
            strTime += ts.Minutes.ToString().PadLeft(2, '0') + ":";
            strTime += ts.Seconds.ToString().PadLeft(2, '0');

            return strTime;
        }

        /// <summary>
        /// 创建对象实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fullName">命名空间.类型名</param>
        /// <param name="assemblyName">程序集</param>
        /// <returns></returns>
        public static T CreateInstance<T>(string strName)
        {
            strName = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace + "." + strName;
            Type type = Type.GetType(strName);
            if (type == null)
            {
                return default(T);
            }

            object obj = Activator.CreateInstance(type);//根据类型创建实例


            return (T)obj;//类型转换并返回
        }

        /// <summary>
        /// 获取本地ip地址,取第一个网卡第一个ipv4的地址
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIP()
        {
            //遍历所有网卡
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation uIpInfo in adapter.GetIPProperties().UnicastAddresses)
                    {
                        if (uIpInfo.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            string localIP = uIpInfo.Address.ToString();
                            //localNetmask = uIpInfo.IPv4Mask.ToString();
                            if (adapter.OperationalStatus == OperationalStatus.Up)
                                return localIP;
                        }
                    }
                }
            }

            return null;
        }

        public static ushort CRC16_C(byte[] data)
        {
            byte CRC16Lo;
            byte CRC16Hi;   //CRC寄存器 
            byte CL; byte CH;       //多项式码&HA001 
            byte SaveHi; byte SaveLo;
            byte[] tmpData;
            int I;
            int Flag;
            CRC16Lo = 0xFF;
            CRC16Hi = 0xFF;
            CL = 0x01;
            CH = 0xA0;
            tmpData = data;
            for (int i = 0; i < tmpData.Length; i++)
            {
                CRC16Lo = (byte)(CRC16Lo ^ tmpData[i]); //每一个数据与CRC寄存器进行异或 
                for (Flag = 0; Flag <= 7; Flag++)
                {
                    SaveHi = CRC16Hi;
                    SaveLo = CRC16Lo;
                    CRC16Hi = (byte)(CRC16Hi >> 1);      //高位右移一位 
                    CRC16Lo = (byte)(CRC16Lo >> 1);      //低位右移一位 
                    if ((SaveHi & 0x01) == 0x01) //如果高位字节最后一位为1 
                    {
                        CRC16Lo = (byte)(CRC16Lo | 0x80);   //则低位字节右移后前面补1 
                    }             //否则自动补0 
                    if ((SaveLo & 0x01) == 0x01) //如果LSB为1，则与多项式码进行异或 
                    {
                        CRC16Hi = (byte)(CRC16Hi ^ CH);
                        CRC16Lo = (byte)(CRC16Lo ^ CL);
                    }
                }
            }
            byte[] ReturnData = new byte[2];
            ReturnData[0] = CRC16Hi;       //CRC高位 
            ReturnData[1] = CRC16Lo;       //CRC低位 

            ushort crc = (ushort)(CRC16Hi << 8);
            crc += CRC16Lo;
            return crc;
        }
    }
}
