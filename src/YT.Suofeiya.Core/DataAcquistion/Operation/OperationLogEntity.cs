using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Core.Operation
{
    public class OperationLogEntity : Entity
    {
        public string code { get; set; }

        public string desc { get; set; }

        public int user { get; set; }

        public DateTime createTime { get; set; }
    }
}
