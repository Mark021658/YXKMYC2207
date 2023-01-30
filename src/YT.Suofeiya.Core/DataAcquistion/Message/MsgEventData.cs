using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace YT.Suofeiya.Core.Message
{
    public enum EnumMsgType
    {
        Debug = 0,
        Info = 1,
        Warn = 2,
        Error = 3,
    }
    public class MsgEventData : EventData
    {
        //消息类型
        public EnumMsgType Type { get; set; }

        //消息具体内容
        public string Msg { get; set; }
    }
}