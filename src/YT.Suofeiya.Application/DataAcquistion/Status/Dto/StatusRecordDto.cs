using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.DataAcquistion.Workpiece;

namespace YT.Suofeiya.DataAcquistion.Status.Dto
{
    public class StatusRecordDto
    {

                /// <summary>
        /// 工序号
        /// </summary>
        public int AcquisitionPointNo { get; set; }

        // 更新日期
        public DateTime? UpdateDate { get; set; }

        // 更新时间
        //public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        //public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        //public DateTime? EndTime { get; set; }

        /// <summary>
        /// 持续时间
        /// </summary>
        public double Duration { get; set; }

        // 当天停机时间
        public double DownTime { get; set; }

        // 当天离线时间
        //public double OfflineTime { get; set; }

        // 当天待机时间
        public double StandByTime { get; set; }

        // 当前数量
        //public int Quantity { get; set; }

        
    }
}
