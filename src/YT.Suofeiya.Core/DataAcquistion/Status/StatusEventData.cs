using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Core.Status
{
    public class StatusEventData : EventData
    {
        public StatusEntity Status { get; set; }
    }
}
