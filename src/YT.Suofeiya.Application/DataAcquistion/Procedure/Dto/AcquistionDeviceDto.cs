namespace YT.Suofeiya.Core.PLC
{
    public class AcquisitionDeviceDto                              //扫描台，电表等设备
    {
        public int Id { get; set; }
        public int AcquisitionDeviceNo { get; set; }

        public int AcquisitionPointNo { get; set; }

        public int AcquisitionDeviceIndex { get; set; }    // 读取数据时候的索引号       

        // 目前 modbus-tcp tcp 倍福(IP 为 netid)  串口(默认波特率为9600)
        public EnumCommunicationMode CommunicationMode { get; set; }

        //public EnumDeviceType DeviceType { get; set; }
        public string IP { get; set; }

        public int Port { get; set; }

        /// <summary>
        /// 从站id 或者 倍福netid     
        /// </summary>
        public int NetID { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }
        
        // 连接状态 0 离线 在线
        public int ConnectionStatus { get; set; }

        // 上下料口编号
        public string Code { get; set; }

        // 用途 上料1扫码 上料2扫码  下料扫码  异常下料1扫码   异常下料2扫码 
        public EnumDeviceUsedType DeviceUsedType { get; set; }

        public AcquisitionDeviceDto()
        {

        }

        public override bool Equals(object obj)
        {
            return obj is AcquisitionDeviceDto dto &&
                   AcquisitionDeviceNo == dto.AcquisitionDeviceNo;
        }

        public override int GetHashCode()
        {
            return -190341915 + AcquisitionDeviceNo.GetHashCode();
        }
    }
}