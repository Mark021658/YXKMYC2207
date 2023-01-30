using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 自定义下拉框选项，匹配<名称> 或者<值>

namespace YT.Suofeiya.UI
{
    class ComboBoxItem
    {
        public readonly static string NAME = "name";
        public readonly static string VALUE = "value";
        public string name { get; set; }

        public object value { get; set; }

        public ComboBoxItem()
        {
        }

        public ComboBoxItem(string _name)
        {
            name = _name;
        }
        public ComboBoxItem(string _name, object _v)
        {
            name = _name;
            value = _v;
        }
        public override bool Equals(object obj)
        {
            return obj is ComboBoxItem item &&
                   (EqualityComparer<object>.Default.Equals(value, item.value)
                   ||
                   EqualityComparer<object>.Default.Equals(name, item.name));
        }

        public override int GetHashCode()
        {
            return -1584136870 + EqualityComparer<object>.Default.GetHashCode(value);
        }
    }
}
