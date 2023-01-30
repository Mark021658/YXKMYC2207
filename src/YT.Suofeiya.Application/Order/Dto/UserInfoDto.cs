using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Order.Dto
{
    public class UserInfoDto
    {
        public string           UserCode            { get; set; }           //工号
        public string           UserName            { get; set; }           //姓名
        public string           Station             { get; set; }           //岗位
        public string           Depart              { get; set; }           //部门
        public string           PassWord            { get; set; }           //密码

    }
}
