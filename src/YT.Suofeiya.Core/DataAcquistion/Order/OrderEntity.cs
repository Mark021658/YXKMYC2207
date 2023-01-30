using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YT.Suofeiya.Core.Order
{
    public enum EnumOrderStatus
    {
        //未下单
        Not = 0,
        //已下单
        Already = 1,        
        //撤单
        Cancel = 2,
        //已完成
        Finish = 3,
    }

    //保存一周的数据，超过一周 并且 已完成的自动移动到历史数据库
    public class OrderEntity : Entity
    {
        //[Index("TitleIndex", IsUnique = true)]
        [Required()]
        [MaxLength(50)]
        public string WorkpieceID { get; set; }

        //生产总编号
        public string ProductionNo { get; set; }

        //下单日期
        public string OrderDate { get; set; }

        //序号 气动打标式样:生产总编号—序号—年月日
        public int No { get; set; }

        //材质
        public int Texture { get; set; }

        //高
        public int Height { get; set; }

        //宽
        public int Width { get; set; }

        //厚
        public int Thinkness { get; set; }

        //玻璃厚度
        public double GlassThinkness { get; set; }

        //合页
        public int Hinge { get; set; }

        //锁具
        public int Lockset { get; set; }

        //锁规则
        public int LocksetRule { get; set; }

        //门扇开向
        public int OpenDirection { get; set; }

        //油漆孔规则
        public int HoleRule { get; set; }

        //是否开静音槽
        public int SilentSlot { get; set; }

        //是否开门顶槽
        public int RoofSlot { get; set; }

        //是否是平板门
        public int FlatDoor { get; set; }

        //门型
        public int DoorType { get; set; }

        //密封槽
        public int SealSlot { get; set; }

        //推拉门结构
        public int SlidingDoorType { get; set; }

        //推拉门凸弧/凹弧
        public int SlidingDoorArc { get; set; }

        //是否雕刻
        public int Sculpture { get; set; }

        //是否掏洞
        public int Cave { get; set; }

        //预留1
        public int Reserved { get; set; }

        //已下单 未下单 撤单 已完成
        public EnumOrderStatus Status { get; set; }

        //如果Status 未下单 则查看此标志，下单进度，bit0 plc1是否下单 bit1 plc2是否下单
        //public int StatusDetail { get; set; }

        //工单编号 无效
        public int WorkOrderNumber{ get; set; }

        //订单添加方式 webservice \ excel导入 \手动添加
        public int InsertType { get; set; }

        //生成贴标机条码
        public string CPrintBarCode { get; set; }
    }
}
