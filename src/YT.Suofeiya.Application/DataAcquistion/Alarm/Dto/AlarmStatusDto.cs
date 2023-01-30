using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Alarm
{
    public class AlarmDto
    {
        public int Id { get; set; }
        // 采集点
        public int AcquisitionPointNo { get; set; }

        //故障号 FaultNo
        public int FaultNo { get; set; }

        // 报警类型  分哪几大类
        public int AlarmType { get; set; }

        // 故障名称
        public string Name { get; set; }

        // 解决方案
        public string Solution { get; set; }

        // 是否报警
        public bool IsAlarm { get; set; }

        // 是否启用
        public bool IsEnable { get; set; }

        // 更新时间
        public DateTime UpdateTime { get; set; }

        // 上一次触发时间
        public DateTime? TrigLastTime { get; set; }

        // 当天报警次数
        public int AlarmNum { get; set; }
    }
}
