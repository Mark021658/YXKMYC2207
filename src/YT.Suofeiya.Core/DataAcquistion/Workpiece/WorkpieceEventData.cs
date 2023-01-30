using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Core.Workpiece
{
    public class WorkpieceEventData: EventData
    {        
        public StatusRecordEntity Workpiece { get; set; }
        public int ProcessStatus { get; set; }
    }
}
