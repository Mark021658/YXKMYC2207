using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Order.Dto
{
    public class DataMappingDto
    {

        public int Id { get; set; }

        public string SourceField { get; set; }

        public string SourceValue { get; set; }

        public string SourceDesc { get; set; }

        public string DestField { get; set; }

        public string DestValue { get; set; }

        public string DestDesc { get; set; }
    }
}
