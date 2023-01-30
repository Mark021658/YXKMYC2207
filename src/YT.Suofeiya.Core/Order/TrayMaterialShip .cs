using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Order
{
    public class TrayMaterialShip :Entity
    {
        /// <summary>
        /// 托盘号
        /// </summary>
        public string PalletCode { get; set; }

        /// <summary>
        /// 木板在托盘第几层
        /// </summary>
        public int SequenceNumber { get; set; }

        /// <summary>
        /// 进料编码
        /// </summary>
        public string MaterialCode { get; set; }

        /// <summary>
        /// 状态，0  1移走、 2移入
        /// </summary>
        public int Status { get; set; }

    }
}
