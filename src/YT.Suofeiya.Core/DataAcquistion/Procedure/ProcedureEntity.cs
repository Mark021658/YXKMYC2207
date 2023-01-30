using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;

namespace YT.Suofeiya.Core.Procedure
{

    // 工序对应多个采集点
    public class ProcedureEntity : Entity
    {
        //工序号
        public int? ProcedureNo { get; set; }

        //工序名称
        public string ProcedureName { get; set; }

        /// <summary>
        /// 工序描述
        /// </summary>
        public string Desc { get; set; }

        public int AcquisitionPointNo { get; set; }

        // 门的ID
        public int DoorId { get; set; }

        // 进入时间
        public DateTime EnterTime { get; set; }

        // 完成时间
        public DateTime? CompleteTime { get; set; }

    }

}
