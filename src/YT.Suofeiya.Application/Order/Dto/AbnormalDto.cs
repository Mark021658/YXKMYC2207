using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Order.Dto
{
    public class AbnormalDto
    {
        //public string RequestCode { set; get; }             //请求编号
        //public string LineCode { set; get; }                //产线编号
        //public string OperationCode { set; get; }           //工序编号
        //public string OperationShortName { set; get; }      //工序短名称
        //public ushort EventCode { set; get; }               //事件码        
        public string   PalletCode              { set; get; }              //托盘号
        public string MaterialCode { set; get; }            //物料编码
        //public string ProductionBatchCode { set; get; }     //生产批次号
        public int NOKQuantity { set; get; }                //不良品数量
        //public List<bujian> NOKSets { set; get; }                //不良品集合
        //public int ScrappedQuantity { set; get; }           //报废数量
        //public List<bujian> ScrappedSets { set; get; }                //报废品集合
        //public string RequestTime { set; get; }             //请求(操作)时间
    }

    //public class bujian
    //{
    //    int SequenceNumber { set; get; }        //顺序号
    //    string PartSerialNumber { set; get; }        //部件条码 
    //}

    //public class Scrapped
    //{
    //    int SequenceNumber { set; get; }        //顺序号
    //    string PartSerialNumber { set; get; }        //部件条码

    //}
    public class AbnormalHisDto
    {
        //public string RequestCode { set; get; }             //请求编号
        //public string LineCode { set; get; }                //产线编号
        //public string OperationCode { set; get; }           //工序编号
        //public string OperationShortName { set; get; }      //工序短名称
        //public ushort EventCode { set; get; }               //事件码        
        public string PalletCode { set; get; }              //托盘号
        public string MaterialCode { set; get; }            //物料编码
        //public string ProductionBatchCode { set; get; }     //生产批次号
        public int NOKQuantity { set; get; }                //不良品数量
        //public List<bujian> NOKSets { set; get; }                //不良品集合
        //public int ScrappedQuantity { set; get; }           //报废数量
        //public List<bujian> ScrappedSets { set; get; }                //报废品集合
        //public string RequestTime { set; get; }             //请求(操作)时间
        public string TaskNumber { get; set; }
    }
}
