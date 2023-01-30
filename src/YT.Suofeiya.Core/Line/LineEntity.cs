using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Line
{
    /// <summary>
    /// 整线参数
    /// </summary>
    public class LineEntity : Entity
    {
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

        // 上次请求编号日期
        public DateTime RequestData { get; set; }

        public int RequestIndex { get; set; }           // 上次请求编号序号
        public string PassWord { get; set; }            //切换模式、员工维护权限密码
        public int LineMode { get; set; }            //产线模式

        /// <summary>
        /// 最后一个采集点(工序)
        /// </summary>
        public int LastPointNo { get; set; }
    }
}
