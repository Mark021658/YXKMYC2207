using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Order.Dto
{
    public class TaskDto
    {
        public int Id { get; set; }

        //
        public string TaskSequenceNumber { get; set; }

        //
        public int FrameType { get; set; }

        //
        public string TaskNumber { get; set; }

        /// <summary>
        /// 生产模式 1-订单模式, 2-批量模式, 3-补单模式
        /// </summary>
        public string WorkMode { get; set; }

        //
        public string OrderDescription { get; set; }

        /// <summary>
        /// 任务单生产数量
        /// </summary>
        public int OrderQuantity { get; set; }
        /// <summary>
        /// 已经完成的数量
        /// </summary>
        public int CompleteQuantity { get; set; }

        // 加工码 - 扫码条码
        public string ProcessCode { get; set; }

        //
        public string DoorStyle { set; get; }

        //
        public int StripSides { set; get; }

        //
        public string PartmatDescription { set; get; }   

        //创建时间
        public DateTime CreateTime { get; set; }

        // 更新时间
        public DateTime UpdateTime { get; set; }


        /// <summary>
        /// 工件长度
        /// </summary>
        public int DoorLength { get; set; }
        /// <summary>
        /// 工件宽度
        /// </summary>
        public int DoorWidth { get; set; }
        /// <summary>
        /// 工件厚度
        /// </summary>
        public int DoorHeight { get; set; }
        /// <summary>
        /// 封边材料
        /// </summary>
        public int BandingMaterial { get; set; }
        /// <summary>
        /// 锁型号1
        /// </summary>
        public string LockType1 { get; set; }
        /// <summary>
        /// 锁型号2 
        /// </summary>
        public string LockType2 { get; set; }
        /// <summary>
        /// 锁规则
        /// </summary>
        public int LockRule { get; set; }
        /// <summary>
        /// 铰链型号1
        /// </summary>
        public string HingeType1 { get; set; }
        /// <summary>
        /// 铰链型号2 
        /// </summary>
        public string HingeType2 { get; set; }
        /// <summary>
        /// 铰链规则
        /// </summary>
        public int HingeRule { get; set; }
        /// <summary>
        /// 顶部加工类型
        /// </summary>
        public int TopWorkType { get; set; }
        /// <summary>
        /// 雕刻类型
        /// </summary>
        public int SculptureType { get; set; }
        /// <summary>
        /// 门标类型
        /// </summary>
        public int LabelType { get; set; }
        /// <summary>
        /// 门标规则
        /// </summary>
        public int LabelRule { get; set; }
        /// <summary>
        /// 底部加工类型
        /// </summary>
        public int BottomWorkType { get; set; }
        /// <summary>
        /// 猫眼
        /// </summary>
        public int Eye { get; set; }
        /// <summary>
        /// 猫眼规则
        /// </summary>
        public int EyeRule { get; set; }
        /// <summary>
        /// 门向标志
        /// </summary>
        public int DirectMark { get; set; }
        /// <summary>
        /// 门扇类型编码
        /// </summary>
        public int DoorTypeCode { get; set; }
        /// <summary>
        /// 顶板长度
        /// </summary>
        public int TopLength { get; set; }
        /// <summary>
        /// 樘口尺寸
        /// </summary>
        public int TangkouSize { get; set; }
        /// <summary>
        /// 连接方式 0-90度, 1-45度
        /// </summary>
        public int LinkType { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        public string DoorColor { set; get; }

        public string LockType
        {
            get
            {
                return this.LockType1 == null ? "" : this.LockType1
                    + this.LockType2 == null ? "" : this.LockType2;
            }
            set
            {
                this.LockType = value;
            }
        }
        public string HingeType
        {
            get
            {
                return this.HingeType1 == null ? "" : this.HingeType1
                    + this.HingeType2 == null ? "" : this.HingeType2;
            }
            set
            {
                this.HingeType = value;
            }
        }
    }
}
