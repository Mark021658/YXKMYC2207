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
using YT.Suofeiya.Core.Tool;
using YT.Suofeiya.Tool;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageOrderTool : UserControlBase
    {
        private readonly IToolAppService _ToolAppService;
        public PageOrderTool()
        {
            InitializeComponent();
            _ToolAppService = IocManager.Instance.Resolve<IToolAppService>();
            dgvProcess.AutoGenerateColumns = false;
            kryptonDateTimePicker1.Value = DateTime.Now;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dt = kryptonDateTimePicker1.Value;
            dgvProcess.DataSource = _ToolAppService.GetAllTool(dt);
        }
    }
}
