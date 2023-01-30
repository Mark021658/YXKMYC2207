using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.DataAcquistion.QuartzTask.Job.DataStruct
{
    public class BitOperate
    {
        /// <summary>
        /// 获取第index位
        /// </summary>

        public static bool GetBit(int b, int index) { return ((b & (1 << index)) > 0); }

        /// <summary>
        /// 将第index位设为1 
        /// </summary>
        public static int SetBit(int b, int index) { return (int)(b | (1 << index)); }
    }
}
