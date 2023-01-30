using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Order
{
    public enum EnumMaterialStatus
    {
        /// <summary>
        /// 未加工
        /// </summary>
        Unprocessed = 0,

        /// <summary>
        /// 加工中
        /// </summary>
        Processing = 1,

        /// <summary>
        /// 加工完成
        /// </summary>
        Completed = 2,

        /// <summary>
        /// 异常出料
        /// </summary>
        Emotional = 3,
    }
}
