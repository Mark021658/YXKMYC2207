using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Order.Dto
{
    public class LineDto
    {
        public int Id;
        // 产线编号
        public string LineCode { get; set; }

        // 工序编号
        public string OperationCode { get; set; }

        // 工序短名称
        public string OperationShortName { get; set; }

        // 设备状态采集周期 ms
        public int AcquisitionCycle { get; set; }

        // 通讯信号交互 周期ms
        public int ScanCycle { get; set; }

        // 缺料呼叫数
        public int QueliaoNum { get; set; }

        // 出口物料数
        public int ExportMaterialsNum { get; set; }
        public string PassWord { get; set; }            //切换模式、员工维护权限密码
        public int LineMode { get; set; }            //产线模式,1自动2手工有条码3手工无条码

        /// <summary>
        /// 最后一个采集点(工序)
        /// </summary>
        public int LastPointNo { get; set; }

    }
}
