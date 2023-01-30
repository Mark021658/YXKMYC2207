using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace YT.Suofeiya.Core.PLC
{
    /**
     * 采集点基本信息
     */
    public class AcquisitionPointEntity : Entity
    {
        // 采集点序号 从0开始 与倍福采集点顺序一致   各个主要机台设备
        public int AcquisitionPointNo { get; set; }

        //采集的索引号 默认为0，  
        public int AcquisitionIndex { get; set; }

        // 采集设备序号 
        public int AcquisitionDeviceNo { get; set; }

        // 名称 相当于工序号
        public string PointName { get; set; }

        // 描述
        public string PointDesc { get; set; }

        // 工序号
        //public int ProcedureNo { get; set; }

        // 正常 普通工序 从0开始 进料口1 下料口 2 异常下料口3 
        public int? ProcedureType { get; set; }

    }
}
