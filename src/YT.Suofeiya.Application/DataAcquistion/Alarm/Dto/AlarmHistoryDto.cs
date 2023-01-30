using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Alarm.Dto
{
    public class AlarmHistoryDto
    {
        // 采集点
        public int AcquisitionPointNo { get; set; }

        public string PointName { get; set; }

        //故障号 FaultNo
        public int FaultNo { get; set; }

        // 故障名称
        public string FaultName { get; set; }

        public int AlarmID { get; set; }

        // 触发时间
        public DateTime? BeginTime { get; set; }

        // 结束时间
        public DateTime? EndTime { get; set; }

        // 持续时间（秒）
        public double Duration { get; set; }
    }
}
