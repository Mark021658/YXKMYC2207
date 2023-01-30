using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Order
{
    /// <summary>
    /// 批次信息
    /// 同一批次门相同加工信息
    /// </summary>
    public class OuterTaskInfoEntity : Entity
    {
        // 任务单 序号
        public string TaskSequenceNumber{ get; set; }

        // 品类类型
        public string CategoryType { get; set; }

        // 生产任务单号
        public string TaskNumber{ get; set; }

        // 下发的生产批次号
        public string  BatchNumber { get; set; }

        // 订单描述（原面单上的物料描述）
        public string OrderDescription { get; set; }

        // 任务单生产数量
        public int Quantity { get; set; }

        // 生产批次号
        public string ProductionBatchCode { get; set; }

        // 加工码 - 扫码条码
        public string ProcessCode { get; set; }

        //门扇款式
        public string DoorStyle { set; get; }

        //颜色
        public string Color { set; get; }

        //线条面数
        public int? StripSides { set; get; }

        public string PartmatDescription { set; get; }   //产品物料的物料编码

        //创建时间
        public DateTime CreateTime { get; set; }                      

        // 更新时间
        public DateTime? UpdateTime { get; set; }


        /// <summary>
        /// 工件长度
        /// </summary>
        public int? DoorLength { get; set; }
        /// <summary>
        /// 工件宽度
        /// </summary>
        public int? DoorWidth { get; set; }
        /// <summary>
        /// 工件厚度
        /// </summary>
        public int? DoorHeight { get; set; }
        /// <summary>
        /// 封边材料
        /// </summary>
        public int? BandingMaterial { get; set; }
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
        public int? LockRule { get; set; }
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
        public int? HingeRule { get; set; }
        /// <summary>
        /// 顶部加工类型
        /// </summary>
        public int? TopWorkType { get; set; }
        /// <summary>
        /// 雕刻类型
        /// </summary>
        public int? SculptureType { get; set; }
        /// <summary>
        /// 门标类型
        /// </summary>
        public int? LabelType { get; set; }
        /// <summary>
        /// 门标规则
        /// </summary>
        public int? LabelRule { get; set; }
        /// <summary>
        /// 底部加工类型
        /// </summary>
        public int? BottomWorkType { get; set; }
        /// <summary>
        /// 猫眼
        /// </summary>
        public int? Eye { get; set; }
        /// <summary>
        /// 猫眼规则
        /// </summary>
        public int? EyeRule { get; set; }
        /// <summary>
        /// 门向标志
        /// </summary>
        public int? DirectMark { get; set; }
        /// <summary>
        /// 门扇类型编码
        /// </summary>
        public int? DoorTypeCode { get; set; }

        public ushort[] GetProcessParams()
        {
            ushort[] processParams = new ushort[17];

            string[] strParams = ProcessCode.Split('*');
            for (int i =0;i < strParams.Length; i++)
            {
                processParams[i] = Convert.ToUInt16(strParams[i]);
            }

            return processParams;
        }
        // 工艺
        /*
    Door_ID:INT;(* 门ID, 条码号*)
Door_Order:STRING;(* 订单号*)
Door_Length :INT;(* 长*)
Door_Width :INT;(* 宽*)
Door_Thick :INT;(* 厚*)
Door_Color:STRING;(* 封边条颜色型号*)
Door_CNC_Number:INT;(* CNC加工序号*)
Door_LOCK :STRING;(* 锁号*)
Door_LOCK_POST :INT;(* 锁规*)
Door_HING: STRING;	(* 铰号*)
Door_HING_POST :INT;(* 铰规*)
Door_Top_Number :INT;(* 门顶加工序号*)
Door_Bottom_Number :INT;(* 门底加工序号*)
Door_Mark:INT;(* 商标安装槽*)
Door_R_L :INT;(* 门向*)
Door_porperty :INT;(* 属性：顶板、档条、、A\B类、侧板等*)
Door_Attachment :INT;(* 附件：猫眼、*)
Door_Process :INT;工艺（组装模式:档条、AB、档条+AB）
*/
    }
}
