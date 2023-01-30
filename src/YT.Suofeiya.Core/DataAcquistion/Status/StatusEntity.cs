using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using YT.Suofeiya.Core.StatusManager;

namespace YT.Suofeiya.Core.Status
{
    public class StatusEntity : Entity
    {
        // 采集点
        public int AcquisitionPointNo { get; set; }

        // 设备状态 离线 0/停机 1/待机 2/运行 3/报警 4  非自动为停机    自动未加工为待机
        public EnumDevStatus DevStatus { get; set; }

        // 上一次状态变化时间  如果时间不是当天全部清零
        public DateTime? StatusChangeTime { get; set; }

        public double PreStatusDuration { get; set; }

        public EnumDevStatus PreDevStatus { get; set; }
        // 更新时间
        public DateTime UpdateTime { get; set; }

        // 状态字
        public int StateWord { get; set; }

        /// <summary>
        /// plc是否上电
        /// </summary>
        public bool StateIsPower { get; set; }

        /// <summary>
        /// 就绪
        /// </summary>
        public bool StateIsReady { get; set; }

        /// <summary>
        /// 是否连线
        /// </summary>
        public bool StateIsConnect { get; set; }

        /// <summary>
        /// 查找数据
        /// </summary>
        public bool StateSearchData { get; set; }

        /// <summary>
        /// 请求进料
        /// </summary>
        public bool StateRequestFeed { get; set; }

        /// <summary>
        /// 工件已进入
        /// </summary>
        public bool StateHasEntered { get; set; }

        /// <summary>
        /// 加工中
        /// </summary>
        public bool StateProcessing { get; set; }

        /// <summary>
        /// 请求出料
        /// </summary>
        public bool StateAllowDischarge { get; set; }

        /// <summary>
        /// 工件已出
        /// </summary>
        public bool StateHasGoneOut { get; set; }

        /// <summary>
        /// 调试
        /// </summary>
        public bool StateDebug { get; set; }

        /// <summary>
        /// 维修
        /// </summary>
        public bool StateRepair { get; set; }


        //主机刀具的使用（1个字，每个位代表一个刀具使用的状态，低位开始）
        //辅助电机的使用
        [NotMapped]
        public bool[] ToolsUsed { get; set; }

        //辅助电机的使用
        // public bool[] MotorsUsed { get; set; }

        // 报警表
        [NotMapped]
        public bool[] Alarms { get; set; }

        // 输入点
        [NotMapped]
        public bool[] SingleX { get; set; }

        // 输出点
        [NotMapped]
        public bool[] SingleY { get; set; }

        // 上一次停机时间
        public DateTime EndTime { get; set; }

        // 上一次开机时间
        public DateTime StartTime { get; set; }

        // 上电时长
        public double PowerTime { get; set; }

        // 运行时长
        public double RunTime { get; set; }

        // 当天停机时间
        public double HaltTime { get; set; }

        // 当天加工时间
        public double ProcessingTime { get; set; }

        // 当天待机时间
        public double StandByTime { get; set; }

        // 当天离线时间
        public double OfflineTime { get; set; }

        // 当天加工数量
        public int Quantity { get; set; }

        // 进料id
        [NotMapped]
        public string InDoorInternalNo;

        // 加工id
        [NotMapped]
        public int ProcessDoorInternalNo;

        // 出料id
        [NotMapped]
        public string OutDoorInternalNo;

        /// <summary>
        /// 清除累加数据
        /// </summary>
        public void Clear()
        {
            Quantity = 0;
            RunTime = 0;
            ProcessingTime = 0;
            PowerTime = 0;
            HaltTime = 0;
        }
    }
}
