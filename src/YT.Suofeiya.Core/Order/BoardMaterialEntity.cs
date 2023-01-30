using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Order;

namespace YT.Suofeiya.Order
{
    public class BoardMaterialEntity : Entity
    {
        //生产任务单号
        public string TaskNumber { get; set; }

        // 生产批次号
        public string ProductionBatchCode { get; set; }
        public ushort MaterialSequenceNumer { set; get; }               //物料序号
        public string MaterialCode { set; get; }                        //物料编码
        public string Description { set; get; }                         //物料描述
        public int MaterialQuality { set; get; }                           //材质
        public int Color { set; get; }                               //颜色
        public string Specification { set; get; }                                //规格（厚*宽*长）
        public string EntranceCode { set; get; }                         //上料口编号
        public int MaterialQuantity { set; get; }                         // 投入物料的数量（总量）

        public DateTime SaveTime { get; set; }                      //保存时间
    }
}
