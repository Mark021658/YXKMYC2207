using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using YT.Suofeiya.DataAcquistion.Workpiece;

namespace YT.Suofeiya.Core.Workpiece
{
    /// <summary>
    /// 加工记录
    /// </summary>
    public class StatusRecordEntity : Entity
    {
        /// <summary>
        /// 门Id号
        /// </summary>
        public string DoorId { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 工序号
        /// </summary>
        public int AcquisitionPointNo { get; set; }

        /// <summary>
        /// 进料、加工、出料、 维修、调试、运行时间(PLC已上电)、停机、生产运行(已连线非连线状态)
        /// </summary>
        public EnumRecordType RecordType { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 持续时间
        /// </summary>
        public double Duration { get; set; }

        /// <summary>
        /// 是否超时报警
        /// </summary>
        public bool IsAlarm { get; set; }

        public bool IsFinish { get; set; }

        /// <summary>
        /// 节拍 与上一次的间隔
        /// </summary>
        public int Rhythm { get; set; }
    }
}
