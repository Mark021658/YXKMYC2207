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
using YT.Suofeiya.Tool;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Tool;
using ComponentFactory.Krypton.Toolkit;
using YT.Suofeiya.Core.Procedure;
using YT.Suofeiya.Procedure;
using YT.Suofeiya.Tool.Dto;
using YT.Suofeiya.DataAcquistion.Procedure.Dto;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageTool : UserControlBase
    {
        private readonly IToolAppService _toolAppService;
        private readonly IProcedureAppService _procedureAppService;

        public PageTool()
        {
            InitializeComponent();

            _toolAppService = IocManager.Instance.Resolve<IToolAppService>();

            _procedureAppService = IocManager.Instance.Resolve<IProcedureAppService>();

            //生成 treeview 视图
            List<AcquisitionDataDto> dataList = _procedureAppService.GetPointDataList().Where(e=>e.DataType == EnumDataType.Status).ToList();
            List<AcquisitionPointDto> listDevName = _procedureAppService.GetPointName();
            for (int i = 0; i < dataList.Count; i++)
            {
                TreeNode node = new TreeNode();
                AcquisitionPointDto point = listDevName.FirstOrDefault(e=>e.AcquisitionPointNo == dataList[i].AcquisitionPointNo);
                //if (listDevName[i].IsTool)
                {
                    node.Text = point.PointName;
                    node.Tag = point.AcquisitionPointNo;
                    tvDev.Nodes.Add(node);
                }
            }

            dgvTool.AutoGenerateColumns = false;
            wornDgv.AutoGenerateColumns = false;

            //dgvTool.DataSource = _toolAppService.Get(1);
            DrawAlarmTreeView();

            UpdateAlarmUI();
        }

        private void UpdateAlarmUI()
        {
            ToolStatisticsDto dto = Abp.Threading.AsyncHelper.RunSync(_toolAppService.GetToolStatistics);

            alarmNumLb.Text = dto.AlarmNum.ToString();

            totalNumLb.Text = dto.TotalNum.ToString();
        }

        //更新刀具
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int caijiID = int.Parse(tbProcedureNo.Text);
                int ToolID = int.Parse(tbToolNo.Text);
                string ToolName = tbName.Text;
                int count = int.Parse(tbLife.Text);
                _toolAppService.Update(caijiID, ToolID,ToolName, count);

                ShowData();
            }
            catch
            {

            }
        }

        //刀具使用次数清零
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                FormToolChange form = new FormToolChange();

                form.ID = tbID.Text;
                form.ToolNo = tbToolNo.Text;
                form.ToolName = tbName.Text;
                form.PointNo = tbProcedureNo.Text;

                int id = int.Parse(tbID.Text);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    _toolAppService.Clear(id, form.OperatorName, form.Remarks, form.IsClear);

                    //更新
                    ShowData();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tvDev_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                DrawAlarmTreeView();

                UpdateAlarmUI();
                if (tvDev.SelectedNode != null)
                {
                    ShowData();
                    dgvTool.CurrentCell = null;
                    tbProcedureNo.Text = null;
                    tbToolNo.Text = null;
                    tbName.Text = null;
                    tbLife.Text = null;
                    tbID.Text = null;
                }
            }
            catch
            {

            }
        }

        private void ShowData()
        {
            int plcNo = Convert.ToInt16(tvDev.SelectedNode.Tag);
            List<ToolDto> list = _toolAppService.GetTools(plcNo);
            dgvTool.DataSource = list.Where(q=>q.WornPartType == 0).ToList();

            wornDgv.DataSource = list.Where(q => q.WornPartType > 0).ToList();

            DrawAlarmRecord();
        }

        private void dgvTool_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTool.SelectedCells.Count != 0)
                {
                    //得到选中行的索引
                    int rowIndex = e.RowIndex;

                    //得到选中行某列的值
                    tbProcedureNo.Text = dgvTool.Rows[rowIndex].Cells["AcquisitionPointNo"].Value.ToString();
                    tbToolNo.Text = dgvTool.Rows[rowIndex].Cells["ToolNo"].Value.ToString();
                    tbName.Text = dgvTool.Rows[rowIndex].Cells["ToolName"].Value.ToString();
                    tbLife.Text = dgvTool.Rows[rowIndex].Cells["PresettingCount"].Value.ToString();
                    tbID.Text = dgvTool.Rows[rowIndex].Cells["Id"].Value.ToString();
                    //MessageBox.Show(str);
                }
            }
            catch
            {

            }

        }

        private void wornDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (wornDgv.SelectedCells.Count != 0)
                {
                    //得到选中行的索引
                    int rowIndex = e.RowIndex;

                    //得到选中行某列的值
                    tbProcedureNo.Text = wornDgv.Rows[rowIndex].Cells[1].Value.ToString();
                    tbToolNo.Text = wornDgv.Rows[rowIndex].Cells[2].Value.ToString();
                    tbName.Text = wornDgv.Rows[rowIndex].Cells[3].Value.ToString();
                    tbLife.Text = wornDgv.Rows[rowIndex].Cells[6].Value.ToString();
                    tbID.Text = wornDgv.Rows[rowIndex].Cells[0].Value.ToString();
                    //MessageBox.Show(str);
                }
            }
            catch
            {

            }

        }


        private void DrawAlarmRecord()
        {
            foreach (DataGridViewRow dgr in dgvTool.Rows)
            {
                object IsAlarm = dgr.Cells["IsAlarm"].Value;
                if (IsAlarm != null)
                {
                    if (Convert.ToBoolean(IsAlarm))
                    {
                        dgr.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }

            foreach (DataGridViewRow dgr in wornDgv.Rows)
            {
                object IsAlarm = dgr.Cells[7].Value;
                if (IsAlarm != null)
                {
                    if (Convert.ToBoolean(IsAlarm))
                    {
                        dgr.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void DrawAlarmTreeView()
        {
            /*
            List<IGrouping<int, ToolsStatusEntity>> list = _toolAppService.AlarmToolProcedureList();


            foreach (TreeNode node in tvDev.Nodes)
            {
                node.ForeColor = Color.Black;

                foreach (IGrouping<int, ToolsStatusEntity> info in list)
                {
                    int plcNo = info.Key;
                    if (Convert.ToInt16(node.Tag) == plcNo)
                    {
                        node.ForeColor = Color.Red;
                        break;
                    }
                }

            }
            */
            
        }


    }
}
