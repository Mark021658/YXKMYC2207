using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Order
{
    public class TaskFieldEntity : AuditedAggregateRoot
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public int Type { get; set; }
    }
}
