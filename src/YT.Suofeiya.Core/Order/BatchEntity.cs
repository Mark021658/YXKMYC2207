using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Order
{
    public class BatchEntity:Entity
    {
        public string PartProperties { set; get; }                      //产品物料的工艺属性
        public string PartMatCode { set; get; }                         //产品物料的物料名称或描述
        public string PartMatDescription { set; get; }                  //产品物料的物料编码
        public string PartMatRoles { set; get; }                        //产品物料的规则
        public string PartsQuantity { set; get; }                       //产品物料的数量
        public string ProductionBatchCode { set; get; }                 //产品批次号
        public string RequestTime { set; get; }                         //请求时间
        public DateTime SaveTime { get; set; }                      //保存时间

    }
}
