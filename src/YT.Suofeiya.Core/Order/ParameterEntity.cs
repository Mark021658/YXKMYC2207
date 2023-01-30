using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Order
{
    public class ParameterEntity : Entity
    {
        public string TaskNumber { get; set; }                          //生产任务单号
        public string ProductionBatchCode { get; set; }                 // 生产批次号
        public ushort ParameterSequenceNumber { set; get; }             //参数序号
        public string ParameterCode { set; get; }                       //参数编码        
        public int ParameterType { set; get; }                          //参数类型
        public string ParameterName { set; get; }                       //参数名称
        public string ParameterValue { set; get; }                      //参数值
    }
}
