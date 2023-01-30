using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace YT.Suofeiya.Core.Tool
{
    /// <summary>
    /// 刀具状态信息
    /// </summary>
    public partial class ToolsRecordEntity : Entity
    {
        //采集点
        public int AcquisitionPointNo { get; set; }

        //刀具编号
        public int ToolNo { get; set; }

        //刀具名称
        public string ToolName { get; set; }

        // 刀具 电机等
        public int WornPartType { get; set; }

        //刀具上一次使用时间
        public DateTime? BeginTime { get; set; }

        //刀具最后一次使用时间
        public DateTime? EndTime { get; set; }

        // 更新时间
        public DateTime? UpdateTime { get; set; }

        // 上一次触发时间
        public DateTime? TrigLastTime { get; set; }

        //刀具使用次数
        public int? UsedCount { get; set; }

        //总共使用时间
        public double? TotalUsedTime { get; set; }

        //刀具预设次数
        public int? PresettingCount { get; set; }

        //刀具当前状态
        public int? ToolStatus { get; set; }

        //刀具当前状态
        public bool? IsUsed { get; set; }

        //如果使用次数大于预设次数报警
        public bool? IsAlarm { get; set; }

        // 上一次更换时间
        public DateTime? ChangeTime { get; set; }

        /// <summary>
        /// 刀具X轴移动距离
        /// </summary>
        public int? DistanceX { get; set; }

        /// <summary>
        /// 刀具Y轴移动距离
        /// </summary>
        public int? DistanceY { get; set; }

        /// <summary>
        /// 刀具Z轴移动距离
        /// </summary>
        public int? DistanceZ { get; set; }

        public int? DoorId { get; set; }

    }
}