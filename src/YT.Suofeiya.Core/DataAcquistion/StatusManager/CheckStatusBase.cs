using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Core.StatusManager
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

    public class CheckStatusBase
    {
        //四种状态 上升沿，下降沿，高，低
        public SIGN_STATE CheckState(bool isProcessing, bool preIsProcessing = false)
        {
            SIGN_STATE signState = SIGN_STATE.Low;

            if (!preIsProcessing && isProcessing)
            {
                signState = SIGN_STATE.RisingEdge;
            }
            else if (preIsProcessing && !isProcessing)
            {
                signState = SIGN_STATE.DescentEdge;
            }
            else if (preIsProcessing && isProcessing)
            {
                signState = SIGN_STATE.High;
            }
            else if (!preIsProcessing && !isProcessing)
            {
                signState = SIGN_STATE.Low;
            }

            return signState;
        }
    }
}
