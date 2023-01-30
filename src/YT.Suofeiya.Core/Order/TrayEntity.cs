using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Order
{
    /// <summary>
    /// 托盘实体
    /// </summary>
    public class TrayEntity : Entity
    {
        /// <summary>
        /// 托盘号
        /// </summary>
        public string PalletCode { get; set; }

        //托盘物料（部件）总数量
        public int PartsQuantity { get; set; }

        public DateTime? UsedTime { get; set; }

        /// <summary>
        /// 最大数量
        /// </summary>
        public int MaxNum { get; set; }

        /// <summary>
        /// 当前数量
        /// </summary>
        public int CurNum { get; set; }

        /// <summary>
        /// 托盘点
        /// </summary>
        //public int TrayPointNo { get; set; }

        public bool CheckIsFull()
        {
            return CurNum == MaxNum;
        }

        public bool CheckIsEmpty(int remainNum)
        {
            return CurNum <= remainNum;
        }
    }
}
