using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Order.Dto
{
    public class TaskFieldDto
    {
        public static readonly int FIELD_TYPE_SOURCE = 0;
        public static readonly int FIELD_TYPE_DEST = 1;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int Type { get; set; }

        public override bool Equals(object obj)
        {
            return obj is TaskFieldDto dto &&
                   (Id == dto.Id ||
                   Code == dto.Code);
        }
    }
}
