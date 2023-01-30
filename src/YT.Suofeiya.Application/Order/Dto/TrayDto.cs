using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Order.Dto
{
    public class TrayDto
    {
        public string LineNo { get; set; }

        // 工序号
        public string ProdureNo { get; set; }

        /// <summary>
        /// 托盘号
        /// </summary>
        public int TrayNo { get; set; }
    }
}
