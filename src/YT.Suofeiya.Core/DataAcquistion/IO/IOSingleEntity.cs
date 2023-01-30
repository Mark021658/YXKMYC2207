using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace YT.Suofeiya.Core.Status
{
    //设备IO信息字典表
    [Table("IOSingleEntity")]
    public class IOSingleEntity : Entity
    {
        // 采集点
        public int AcquisitionPointNo { get; set; }

        // 信号顺序 FaultNo
        public int FaultNo { get; set; }

        // 信号类型 输入/输出 分哪几大类
        public int SingleType { get; set; }

        // 信号名称
        public string Name { get; set; }

        //// 解决方案
        //public string Solution { get; set; }

        // 是否报警
        [NotMapped]
        public bool SingleValue { get; set; }

        //// 是否启用
        //public bool IsEnable { get; set; }

        // 更新时间
        [NotMapped]
        public DateTime UpdateTime { get; set; }

        //// 上一次触发时间
        //public DateTime? TrigLastTime { get; set; }

        //// 当天报警次数
        //public int AlarmNum { get; set; }

        //[NotMapped]
        //public int LastRecordID { get; set; }
    }
}
