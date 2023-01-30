using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT.Suofeiya.Core.Tool;
using YT.Suofeiya.Tool;
using YT.Suofeiya.Procedure;
using Abp.Dependency;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageToolRecord : UserControlBase
    {

        private readonly IToolAppService _toolAppService;

        private readonly IProcedureAppService _processNameAppService;

        Dictionary<string, int> dicName = new Dictionary<string, int>();
        public PageToolRecord()
        {
            InitializeComponent();

            _toolAppService = IocManager.Instance.Resolve<IToolAppService>();

            _processNameAppService = IocManager.Instance.Resolve<IProcedureAppService>();

            foreach (var item in _processNameAppService.GetPointName())
            {
                cbProcessName.Items.Add(item.PointName);
                dicName.Add(item.PointName, item.AcquisitionPointNo);
            }

            cbProcessName.Items.Add("所有");

            kryptonDateTimePicker2.Value = DateTime.Now.Date;

            dgvToolRecord.AutoGenerateColumns = false;
        }

        private void PageToolRecord_Load(object sender, EventArgs e)
        {
            
        }

        private void butQuery_Click(object sender, EventArgs e)
        {
            List<ToolChangeDto> data = _toolAppService.GetToolChangeRecord(kryptonDateTimePicker1.Value.Date, kryptonDateTimePicker2.Value.AddDays(1).Date);

            if (cbProcessName.Text != "所有")
            {
                data = data.Where(q => q.AcquisitionPointNo == dicName[cbProcessName.Text]).ToList();
            }

            dgvToolRecord.DataSource = data;
        }
    }
}
