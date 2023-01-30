using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Alarm.Dto
{
    [Serializable]
    public class FaultToMesDto
    {
        public string systemID { get; set; }
        public string deviceCode { get; set; }
        public string faultCode { get; set; }
        public string faultCause { get; set; }
        public string faultExInfo { get; set; }
        public string faultTime { get; set; }
    }
}
