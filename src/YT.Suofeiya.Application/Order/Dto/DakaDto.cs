using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Order.Dto
{
    public class DakaDto
    {
        public string           UserCode            { get; set; }           //工号
        public string           UserName            { get; set; }           //姓名
        public string           Riqi                { get; set; }           //打卡日期
        public string           CheckType           { get; set; }           //打卡类别
        public DateTime         SaveTime             { get; set; }           //保存时间

    }
}
