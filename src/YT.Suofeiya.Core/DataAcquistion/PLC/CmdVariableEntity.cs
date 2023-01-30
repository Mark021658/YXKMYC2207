using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.DataAcquistion.PLC
{
    public class CmdVariableEntity : Entity
    {
        // 扫托盘  扫不合格   扫内部序号
        public int CmdType { get; set; }
        public string RequsetVariabeName { get; set; }

        public string ResponseVariabeName { get; set; }

        public int PointNo { get; set; }
    }
}
