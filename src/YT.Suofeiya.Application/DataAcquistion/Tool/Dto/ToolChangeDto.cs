using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Core.Tool
{
    public class ToolChangeDto
    {
        //采集点
        public int AcquisitionPointNo { get; set; }

        //刀具编号
        public int ToolNo { get; set; }

        public string ToolName { get; set; }

        //更换时间
        public DateTime ChangeTime { get; set; }

        //操作工姓名
        public string OperaterName { get; set; }

        //使用时长
        public double UsedTime { get; set; }

        //备注
        public string Remarks { get; set; }
    }
}
