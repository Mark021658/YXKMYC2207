using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Scan;

namespace YT.Suofeiya.Order
{
    public class TrayPointEntity:Entity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int PointNo { get; set; }

        // 跟哪个扫码枪绑定
        public int DeviceNo { get; set; }

        /// <summary>
        /// 所属工序号
        /// </summary>
        public int ProducerNo { get; set; }

        // 上料口编号
        //public string EntranceCode { get; set; }
        /// <summary>
        /// 当前托盘号，-1为空
        /// </summary>
        public string PalletCode { get; set; }

        // 类型 0 进料口  1 合格品出料口 2不良品出料口
        public int PointType { get; set; }

        // 当前物料数量
        public int CurNum { get; set; }

        // 是否可以取料、下料 
        public bool IsEnable { get; set; }

        // 是否正在使用
        public bool IsUsed { get; set; }

        public string BeifuRequsetVariabeName { get; set; }

        public string BeifuResponseVariabeName { get; set; }

        public string BeifuCountVariabeName { get; set; }
    }
}
