using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Order
{
    public class DataMappingEntity : AuditedAggregateRoot
    {
        public string SourceField { get; set; }

        public string SourceValue { get; set; }

        public string SourceDesc { get; set; }

        public string DestField { get; set; }

        public string DestValue { get; set; }

        public string DestDesc { get; set; }
    }
}
