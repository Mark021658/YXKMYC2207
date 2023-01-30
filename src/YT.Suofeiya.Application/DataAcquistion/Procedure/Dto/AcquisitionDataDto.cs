namespace YT.Suofeiya.Core.PLC
{
    public class AcquisitionDataDto
    {
        public int Id { get; set; }
        // 采集点序号
        public int AcquisitionPointNo { get; set; }

        // 读取的开始地址
        public int StartAddr { get; set; }

        // 数据字数
        public int Words { get; set; }

        // 类型固定 使用枚举enum
        public EnumDataType DataType { get; set; }

        // 读写权限
        public int Permission { get; set; }

        // 读取周期时间 ms
        public int CycleTime { get; set; }
    }
}
