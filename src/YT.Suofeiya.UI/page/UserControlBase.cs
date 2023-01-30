using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YT.Suofeiya.UI
{
    public partial class UserControlBase : UserControl, ITransientDependency
    {
        public IntPtr MainFormHandle;
        public UserControlBase()
        {
            InitializeComponent();
        }

        private void UserControlBase_Load(object sender, EventArgs e)
        {

        }
    }
}
