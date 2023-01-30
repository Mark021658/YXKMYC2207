using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.ComponentModel.Design
{
    public class ListBoxItem : IDisposable
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string No { get; set; }

        public string Desc { get; set; }

        [System.ComponentModel.DefaultValue(typeof(System.Drawing.Image), "null")]
        public System.Drawing.Image Image { get; set; }

        public bool IsFocus { get; set; }

        public ListBoxItem() { }

        public ListBoxItem(Guid id, string name, string ip, string mac, System.Drawing.Image image)
        {
            this.Id = id;
            this.Name = name;
            this.No = ip;
            this.Desc = mac;
            this.Image = image;
            this.IsFocus = false;
        }

        public void Dispose()
        {
            this.Image = null;
        }
    }
}
