using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Core.Alarm
{
    public class AlarmEventData : EventData
    {
        //系统id  系统名称
        //4	      闼闼宿州工厂01车间木工一线控制系统
        public int SystemID { get; set; }
        public string DeviceCode { get; set; }
        public int FaultCode { get; set; }
        public string FaultCause { get; set; }
        public string FaultExInfo { get; set; }
        public string FaultTime { get; set; }          
    }
}

