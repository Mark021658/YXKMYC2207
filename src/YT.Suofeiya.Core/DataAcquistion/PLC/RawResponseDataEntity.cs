using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Core.PLC
{
    public class RawResponseDataEntity : Entity
    {

        public int AcquisitionPointNo { get; set; }
        public string data { get; set; }
        public DateTime createTime { get; set; }
    }
}
