using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Scan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GET_SCAN_DOOR
    {
        /// <summary>
        /// 工件长度
        /// </summary>
        public UInt16 length;
        /// <summary>
        /// 工件宽度
        /// </summary>
        public UInt16 width;
        /// <summary>
        /// 工件厚度
        /// </summary>
        public UInt16 height;
        /// <summary>
        /// 封边材料
        /// </summary>
        public UInt16 bandingMaterial;
        /// <summary>
        /// 锁型号1 - 字符ASCII
        /// </summary>
        public UInt16 lockType1;
        /// <summary>
        /// 锁型号2 - 字符ASCII
        /// </summary>
        public UInt16 lockType2;
        /// <summary>
        /// 锁规则
        /// </summary>
        public UInt16 lockRule;
        /// <summary>
        /// 铰链型号1 - 字符ASCII
        /// </summary>
        public UInt16 hingeType1;
        /// <summary>
        /// 铰链型号2 - 字符ASCII
        /// </summary>
        public UInt16 hingeType2;
        /// <summary>
        /// 铰链规则
        /// </summary>
        public UInt16 hingeRule;
        /// <summary>
        /// 顶部加工类型
        /// </summary>
        public UInt16 topWorkType;
        /// <summary>
        /// 雕刻类型
        /// </summary>
        public UInt16 sculptureType;
        /// <summary>
        /// 门标类型
        /// </summary>
        public UInt16 labelType;
        /// <summary>
        /// 门标规则
        /// </summary>
        public UInt16 labelRule;
        /// <summary>
        /// 底部加工类型
        /// </summary>
        public UInt16 bottomWorkType;
        /// <summary>
        /// 猫眼
        /// </summary>
        public UInt16 eye;
        /// <summary>
        /// 猫眼规则
        /// </summary>
        public UInt16 eyeRule;
        /// <summary>
        /// 门向标志
        /// </summary>
        public UInt16 directMark;
        /// <summary>
        /// 门扇类型编码
        /// </summary>
        public UInt16 doorTypeCode;
        /// <summary>
        /// 空位
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public UInt16[] other;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public UInt16[] doorId;
        /// <summary>
        /// 标记数据已经完整
        /// </summary>
        public UInt16 mark;
        /// <summary>
        /// <para>状态位</para>
        /// <para>读：bit1为1开始扫描</para>
        /// <para>写：bit2置1确认正确</para>
        /// </summary>
        public UInt16 status;

        public override bool Equals(object obj)
        {
            return obj is GET_SCAN_DOOR dOOR &&
                   length == dOOR.length &&
                   width == dOOR.width &&
                   height == dOOR.height &&
                   bandingMaterial == dOOR.bandingMaterial &&
                   lockType1 == dOOR.lockType1 &&
                   lockType2 == dOOR.lockType2 &&
                   lockRule == dOOR.lockRule &&
                   hingeType1 == dOOR.hingeType1 &&
                   hingeType2 == dOOR.hingeType2 &&
                   hingeRule == dOOR.hingeRule &&
                   topWorkType == dOOR.topWorkType &&
                   sculptureType == dOOR.sculptureType &&
                   labelType == dOOR.labelType &&
                   labelRule == dOOR.labelRule &&
                   bottomWorkType == dOOR.bottomWorkType &&
                   eye == dOOR.eye &&
                   eyeRule == dOOR.eyeRule &&
                   directMark == dOOR.directMark &&
                   doorTypeCode == dOOR.doorTypeCode;
        }

        public override int GetHashCode()
        {
            int hashCode = -2095270627;
            hashCode = hashCode * -1521134295 + length.GetHashCode();
            hashCode = hashCode * -1521134295 + width.GetHashCode();
            hashCode = hashCode * -1521134295 + height.GetHashCode();
            hashCode = hashCode * -1521134295 + bandingMaterial.GetHashCode();
            hashCode = hashCode * -1521134295 + lockType1.GetHashCode();
            hashCode = hashCode * -1521134295 + lockType2.GetHashCode();
            hashCode = hashCode * -1521134295 + lockRule.GetHashCode();
            hashCode = hashCode * -1521134295 + hingeType1.GetHashCode();
            hashCode = hashCode * -1521134295 + hingeType2.GetHashCode();
            hashCode = hashCode * -1521134295 + hingeRule.GetHashCode();
            hashCode = hashCode * -1521134295 + topWorkType.GetHashCode();
            hashCode = hashCode * -1521134295 + sculptureType.GetHashCode();
            hashCode = hashCode * -1521134295 + labelType.GetHashCode();
            hashCode = hashCode * -1521134295 + labelRule.GetHashCode();
            hashCode = hashCode * -1521134295 + bottomWorkType.GetHashCode();
            hashCode = hashCode * -1521134295 + eye.GetHashCode();
            hashCode = hashCode * -1521134295 + eyeRule.GetHashCode();
            hashCode = hashCode * -1521134295 + directMark.GetHashCode();
            hashCode = hashCode * -1521134295 + doorTypeCode.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<ushort[]>.Default.GetHashCode(other);
            hashCode = hashCode * -1521134295 + status.GetHashCode();
            return hashCode;
        }

        public void reset()
        {
            length = 0;
            width = 0;
            height = 0;
            bandingMaterial = 0;
            lockType1 = 0;
            lockType2 = 0;
            lockRule = 0;
            hingeType1 = 0;
            hingeType2 = 0;
            hingeRule = 0;
            topWorkType = 0;
            sculptureType = 0;
            labelType = 0;
            labelRule = 0;
            bottomWorkType = 0;
            eye = 0;
            eyeRule = 0;
            directMark = 0;
            doorTypeCode = 0;
            mark = 0;
            doorId = new UInt16[2];
        }

        public ushort[] toUShortArr()
        {
            ushort[] ushorts = new ushort[30];
            ushorts[0] = this.length;
            ushorts[1] = this.width;
            ushorts[2] = this.height;
            ushorts[3] = this.bandingMaterial;
            ushorts[4] = this.lockType1;
            ushorts[5] = this.lockType2;
            ushorts[6] = this.lockRule;
            ushorts[7] = this.hingeType1;
            ushorts[8] = this.hingeType2;
            ushorts[9] = this.hingeRule;
            ushorts[10] = this.topWorkType;
            ushorts[11] = this.sculptureType;
            ushorts[12] = this.labelType;
            ushorts[13] = this.labelRule;
            ushorts[14] = this.bottomWorkType;
            ushorts[15] = this.eye;
            ushorts[16] = this.eyeRule;
            ushorts[17] = this.directMark;
            ushorts[18] = this.doorTypeCode;

            ushorts[26] = this.doorId[0];
            ushorts[27] = this.doorId[1];
            ushorts[28] = this.mark;
            ushorts[29] = this.status;
            return ushorts;
        }
    }
}
