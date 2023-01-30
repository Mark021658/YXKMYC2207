using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.DataAcquistion.Status;

namespace YT.Suofeiya.Status.Dto
{
    public class StatusDto
    {
        // 采集点
        public int AcquisitionPointNo { get; set; }

        // 设备状态 离线 0/停机 1/待机 2/运行 3/报警 4  非自动为停机    自动未加工为待机
        public EnumDevStatus DevStatus { get; set; }

        // 上一次状态变化时间  如果时间不是当天全部清零
        public DateTime? StatusChangeTime { get; set; }

        public double PreStatusDuration { get; set; }

        public EnumDevStatus PreDevStatus { get; set; }

        // 更新时间
        public DateTime UpdateTime { get; set; }

        // 状态字
        public int StateWord { get; set; }

        //plc是否上电
        public bool StateIsPower { get; set; }

        //就绪
        public bool StateIsReady { get; set; }

        //是否连线
        public bool StateIsConnect { get; set; }

        //查找数据
        public bool StateSearchData { get; set; }

        //请求进料
        public bool StateRequestFeed { get; set; }

        //工件已进入
        public bool StateHasEntered { get; set; }

        //加工中
        public bool StateProcessing { get; set; }

        //请求出料
        public bool StateAllowDischarge { get; set; }

        //工件已出
        public bool StateHasGoneOut { get; set; }

        // 上一次停机时间
        public DateTime EndTime { get; set; }

        // 上一次开机时间
        public DateTime StartTime { get; set; }

        // 当天加工时间
        public double ProcessingTime { get; set; }

        // 当天待机时间
        public double StandByTime { get; set; }

        // 当天停机时间
        public double DownTime { get; set; }

        // 当天离线时间
        public double OfflineTime { get; set; }
    }
}
