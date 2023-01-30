using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.StatusManager;
using YT.Suofeiya.DataAcquistion.Workpiece;

namespace YT.Suofeiya.Core.Status
{
    // 设备状态变更记录
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

        // 更新日期
        public DateTime? UpdateDate { get; set; }

        // 更新时间
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 持续时间
        /// </summary>
        public double Duration { get; set; }

        // 当天停机时间
        public double DownTime { get; set; }

        // 当天离线时间
        public double OfflineTime { get; set; }

        // 当天待机时间
        public double StandByTime { get; set; }

        // 当前数量
        public int Quantity { get; set; }

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
