using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.DataAcquistion.Workpiece
{
    public enum EnumRecordType
    {
        /// <summary>
        /// 进料
        /// </summary>
        Feed = 0,

        /// <summary>
        /// 加工
        /// </summary>
        Process = 1,

        /// <summary>
        /// 出料
        /// </summary>
        Discharge = 2,

        /// <summary>
        /// 调试
        /// </summary>
        Debug = 3,

        /// <summary>
        /// 维修
        /// </summary>
        Repair = 4,

        /// <summary>
        /// 停止
        /// </summary>
        Halt = 5,

        /// <summary>
        /// 运行
        /// </summary>
        Run = 6,

        /// <summary>
        /// 上电
        /// </summary>
        Power = 7,
    }
}
