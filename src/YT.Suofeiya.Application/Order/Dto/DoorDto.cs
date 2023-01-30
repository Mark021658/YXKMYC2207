using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Order.Dto
{
    public class DoorDto
    {
        public int Id { get; set; }

        /// <summary>
        /// 生产任务单号
        /// </summary>
        public int TaskId { get; set; }

        // 当前状态 在第几个工序上 -1 未加工 -2 完成
        public int ProcessIndex { get; set; }

        //保存时间
        public DateTime SaveTime { get; set; }

        public DateTime? EndTime { get; set; }

        // 耗时
        public int duration 
        { 
            get 
            {
                int d = 0;
                if (this.EndTime != null)
                {
                    d = Convert.ToInt32(((DateTime)this.EndTime).Subtract(this.SaveTime).TotalSeconds);
                }
                return d;
            }
            set
            {
                this.duration = value;
            }
        
        }

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
