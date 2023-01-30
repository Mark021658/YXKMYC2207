using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abp.Dependency;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageClockIn : UserControlBase
    {

        public PageClockIn()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Text = comboBox1.Text.Substring(0, comboBox1.Text.IndexOf(":"));
            kryptonLabel5.Text = comboBox1.Text.Substring(comboBox1.Text.IndexOf(":") + 1, comboBox1.Text.Length- comboBox1.Text.IndexOf(":")-1);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
