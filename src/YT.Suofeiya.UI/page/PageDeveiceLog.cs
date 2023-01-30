using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT.Suofeiya.Core.Status;
using YT.Suofeiya.Status;
using Abp.Dependency;
using YT.Suofeiya.DataAcquistion.Status.Dto;
using YT.Suofeiya.Procedure;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageDeveiceLog : UserControlBase
    {
        private readonly IStatusAppService _statusAppService;
        private readonly IProcedureAppService _processNameAppService;
        public PageDeveiceLog()
        {
            InitializeComponent();
            _statusAppService = IocManager.Instance.Resolve<IStatusAppService>();

            _processNameAppService = IocManager.Instance.Resolve<IProcedureAppService>();

            foreach (var item in _processNameAppService.GetPointName())
            {
                cbProcessName.Items.Add(item.PointName);
            }
            cbProcessName.Items.Add("所有");
        }

        private void butQuery_Click(object sender, EventArgs e)
        {
            List<StatusRecordDto> records = _statusAppService.GetStatusRecords(dateTimePicker1.Value, kryptonDateTimePicker1.Value);

            kryptonDataGridView1.DataSource = records;
        }
    }
}
