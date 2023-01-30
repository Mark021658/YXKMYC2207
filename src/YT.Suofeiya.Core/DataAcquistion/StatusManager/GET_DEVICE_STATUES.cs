using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Core.StatusManager
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GET_DEVICE_STATUES
    {
        // x 10
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public UInt16[] x;

        // y 10
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public UInt16[] y;

        // m 20
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public UInt16[] m;

        // 状态字 30
        //bit0 手/自动
        //bit1 已/未就绪
        //bit2 有/无报警
        //bit3 数据查找中
        //bit4 请求进料
        //bit5 工件已进入
        //bit6 加工中
        //bit7 请求出料
        //bit8 工件已出
        public UInt16 devState;

        //主机刀具的使用（1个字，每个位代表一个刀具使用的状态，低位开始）31
        ////电机使用字 32 2
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public UInt16[] toolsUsed;

        // 报警 34 2
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public UInt16[] alarms;

        // 备用点 36 4
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public UInt16[] Beiyongs;

        // 加工数据 40 26
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 27)]
        public UInt16[] OrderData;

        // 工件ID 67 2
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public UInt16[] DoorId;

        // 工件ID 68 12
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        public UInt16[] Other;

        
    }


    [StructLayout(LayoutKind.Sequential)]   //lvxa
    public struct GET_ORDER
    {
        //条码长度
        public UInt16 DataLength;
        //空格
        public UInt16 Space;
        //生产单ID
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public UInt16[] ProductionID;

    }
}
