using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;

namespace YT.Suofeiya.Scan
{
    public class ScanCompletedEventData: EventData
    {
        /// <summary>
        /// 哪个点扫描的
        /// </summary>
        public AcquisitionDeviceEntity AcquistionDevice { get; set; }
        
        /// <summary>
        /// 扫描数据
        /// </summary>
        public string Data { get; set; }
    }
}
