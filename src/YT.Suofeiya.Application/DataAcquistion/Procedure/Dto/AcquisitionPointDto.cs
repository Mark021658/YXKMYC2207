using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.DataAcquistion.Procedure.Dto
{
    public class AcquisitionPointDto
    {
        public int Id { get; set; }
        // 采集点序号
        public int AcquisitionPointNo { get; set; }

        public int AcquisitionIndex { get; set; }

        // 采集设备序号 
        public int AcquisitionDeviceNo { get; set; }

        // 名称
        public string PointName { get; set; }

        // 工序号
        public int ProcedureNo { get; set; }

        // 正常 进料口 异常下料口 正常下料口
        public int ProcedureType { get; set; }

        public string PointDesc { get; set; }

        public override bool Equals(object obj)
        {
            return obj is AcquisitionPointDto dto &&
                   AcquisitionPointNo == dto.AcquisitionPointNo;
        }

        public override int GetHashCode()
        {
            return 949988945 + AcquisitionPointNo.GetHashCode();
        }
    }
}
