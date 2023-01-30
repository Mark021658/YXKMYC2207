using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.DataAcquistion.Status
{
    /// <summary>
    /// 信号状态，高低，上升沿，下降沿
    /// </summary>
    public enum SIGN_STATE
    {
        High,
        Low,
        RisingEdge,
        DescentEdge,
    }

    // 设备状态 离线 0/停机 1/待机 2/运行 3/报警 4 
    public enum EnumDevStatus
    {
        Offline = 0,
        Down,
        StandBy,
        Processing,
        Alarm,
    }
}
