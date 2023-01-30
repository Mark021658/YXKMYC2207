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
using YT.Suofeiya.DataAcquistion.Procedure.Dto;
using YT.Suofeiya.Procedure;
using YT.Suofeiya.Tool;
using YT.Suofeiya.Tool.Dto;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageToolManage : UserControlBase
    {

        private readonly IToolAppService _toolAppService;
        private readonly IProcedureAppService _procedureAppService;

        List<ToolDto> listTool;
        List<AcquisitionPointDto> listPoint;
        public PageToolManage()
        {
            _toolAppService = IocManager.Instance.Resolve<IToolAppService>();
            _procedureAppService = IocManager.Instance.Resolve<IProcedureAppService>();
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            // 刷新列表
            listTool = _toolAppService.GetAll();
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.DataSource = listTool;

            listPoint = _procedureAppService.GetPointName();
            this.kcb_pointNo.DataSource = listPoint;
            this.kcb_pointNo.DisplayMember = "PointName";
            this.kcb_pointNo.ValueMember = "AcquisitionPointNo";

            cleanTextBox();

        }

        // 清空编辑框
        public void cleanTextBox()
        {
            ktb_toolNo.Text = "";
            ktb_toolName.Text = "";
            ktb_wornPartType.Text = "";
            ktb_ID.Text = "";
            ktb_presettingCount.Text = "";
        }
        private void kryptonDataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (kryptonDataGridView1.SelectedCells.Count != 0)
                {
                    cleanTextBox();

                    //得到选中行的索引
                    int rowIndex = e.RowIndex;

                    //得到选中行某列的值
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["pointId"].Value != null)
                    { 
                        ktb_ID.Text = kryptonDataGridView1.Rows[rowIndex].Cells["pointId"].Value.ToString();
                    
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionPointNo"].Value != null)
                    {
                        string pointNo = kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionPointNo"].Value.ToString();
                        kcb_pointNo.SelectedItem = new AcquisitionPointDto { AcquisitionPointNo = int.Parse(pointNo) };
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["ToolNo"].Value != null)
                    { 
                        ktb_toolNo.Text = kryptonDataGridView1.Rows[rowIndex].Cells["ToolNo"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["ToolName"].Value != null)
                    { 
                        ktb_toolName.Text = kryptonDataGridView1.Rows[rowIndex].Cells["ToolName"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["WornPartType"].Value != null)
                    { 
                        ktb_wornPartType.Text = kryptonDataGridView1.Rows[rowIndex].Cells["WornPartType"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["PresettingCount"].Value != null)
                    {
                        ktb_presettingCount.Text = kryptonDataGridView1.Rows[rowIndex].Cells["PresettingCount"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["DistanceX_Addr"].Value != null)
                    {
                        ktb_xAddr.Text = kryptonDataGridView1.Rows[rowIndex].Cells["DistanceX_Addr"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["DistanceY_Addr"].Value != null)
                    {
                        ktb_yAddr.Text = kryptonDataGridView1.Rows[rowIndex].Cells["DistanceY_Addr"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["DistanceZ_Addr"].Value != null)
                    {
                        ktb_zAddr.Text = kryptonDataGridView1.Rows[rowIndex].Cells["DistanceZ_Addr"].Value.ToString();
                    }

                    //MessageBox.Show(str);
                }
            }
            catch
            {

            }
        }

        private void kryptonHeaderGroup1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ktb_ID.Text;
                string pointNo = kcb_pointNo.SelectedValue.ToString();
                string toolNo = ktb_toolNo.Text;
                string toolName = ktb_toolName.Text;
                string wornPartType = ktb_wornPartType.Text;
                string presettingCount = ktb_presettingCount.Text;
                string xAddr = ktb_xAddr.Text;
                string yAddr = ktb_yAddr.Text;
                string zAddr = ktb_zAddr.Text;
                ToolDto tool = new ToolDto
                { 
                    AcquisitionPointNo = int.Parse(pointNo),
                    ToolNo = int.Parse(toolNo),
                    ToolName = toolName,
                    WornPartType = int.Parse(wornPartType),
                    PresettingCount = int.Parse(presettingCount),
                    DistanceX_Addr = int.Parse(xAddr),
                    DistanceY_Addr = int.Parse(yAddr),
                    DistanceZ_Addr = int.Parse(zAddr)
                };

                if (id.Equals(""))
                {
                    // 新建
                    _toolAppService.createTool(tool);
                }
                else
                {
                    // 更新
                    tool.Id = int.Parse(id);
                    _toolAppService.updateTool(tool);
    
                }

                this.refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kryptonRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
