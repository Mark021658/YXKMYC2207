using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace YT.Suofeiya.Core.Alarm
{
    //设备报警记录
    [Table("DevAlarmHistoryRecord")]
    public class AlarmRecordEntity : Entity
    {
        public int AlarmID { get; set; }

        // 触发时间
        public DateTime? BeginTime{ get; set; }

        // 结束时间
        public DateTime? EndTime { get; set; }

        // 持续时间（秒）
        public double Duration { get; set; }
    }
}
