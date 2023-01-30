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
using YT.Suofeiya.Procedure;
using YT.Suofeiya.Order;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageOrderTrace : UserControlBase
    {
        Dictionary<string, int> dicName = new Dictionary<string, int>();

        private readonly IProcedureAppService _processNameAppService;
        private readonly IDoorManager _DoorManager;

        public PageOrderTrace()
        {
            InitializeComponent();

            _processNameAppService = IocManager.Instance.Resolve<IProcedureAppService>();
            _DoorManager = IocManager.Instance.Resolve<IDoorManager>();

            dgvProcess.AutoGenerateColumns = false;
            kryptonDataGridView1.AutoGenerateColumns = false;
            kryptonDateTimePicker1.Value = DateTime.Now;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dt = kryptonDateTimePicker1.Value;
            dgvProcess.DataSource = _DoorManager.GetAllDoor(dt);
        }

        private void buttonSpecHeaderGroup1_Click(object sender, EventArgs e)
        {

        }
        private void dgvProcess_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProcess.SelectedCells.Count != 0)
                {
                    //得到选中行的索引
                    int rowIndex = e.RowIndex;

                    if (dgvProcess.Rows[rowIndex].Cells["Id"].Value != null)
                    {
                        int doorId = int.Parse(dgvProcess.Rows[rowIndex].Cells["Id"].Value.ToString());
                        kryptonDataGridView1.DataSource = _DoorManager.GetProcedureList(doorId);
                        
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
