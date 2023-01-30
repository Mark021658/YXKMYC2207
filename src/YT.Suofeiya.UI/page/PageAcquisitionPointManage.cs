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
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.DataAcquistion.Procedure.Dto;
using YT.Suofeiya.Procedure;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageAcquisitionPointManage : UserControlBase
    {

        private readonly IProcedureAppService _procedureAppService;

        List<AcquisitionPointDto> listPoint;
        List<AcquisitionDeviceDto> listDevice;
        public PageAcquisitionPointManage()
        {
            _procedureAppService = IocManager.Instance.Resolve<IProcedureAppService>();
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            // 刷新列表
            listPoint = _procedureAppService.GetPointName();
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.DataSource = listPoint;

            listDevice = _procedureAppService.GetPointDeviceList();
            this.kcb_deviceNo.DataSource = listDevice;
            this.kcb_deviceNo.DisplayMember = "Name";
            this.kcb_deviceNo.ValueMember = "AcquisitionDeviceNo";

            cleanTextBox();

        }

        // 清空编辑框
        public void cleanTextBox()
        {
            ktb_pointNo.Text = "";
            ktb_pointName.Text = "";
            ktb_pointIndex.Text = "";
            ktb_pointDesc.Text = "";
            ktb_pointType.Text = "";
            ktb_ID.Text = "";
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
                        ktb_pointNo.Text = kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionPointNo"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["PointName"].Value != null)
                    { 
                        ktb_pointName.Text = kryptonDataGridView1.Rows[rowIndex].Cells["PointName"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionIndex"].Value != null)
                    { 
                        ktb_pointIndex.Text = kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionIndex"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["PointDesc"].Value != null)
                    { 
                        ktb_pointDesc.Text = kryptonDataGridView1.Rows[rowIndex].Cells["PointDesc"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["ProcedureType"].Value != null)
                    { 
                        ktb_pointType.Text = kryptonDataGridView1.Rows[rowIndex].Cells["ProcedureType"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionDeviceNo"].Value != null)
                    {
                        string deviceNo = kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionDeviceNo"].Value.ToString();
                        this.kcb_deviceNo.SelectedItem = new AcquisitionDeviceDto { AcquisitionDeviceNo = int.Parse(deviceNo) };
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
                string pointNo = ktb_pointNo.Text;
                string pointName = ktb_pointName.Text;
                string pointIndex = ktb_pointIndex.Text;
                string pointType = ktb_pointType.Text;
                string pointDesc = ktb_pointDesc.Text;
                string deviceNo = kcb_deviceNo.SelectedValue.ToString();
                AcquisitionPointDto point = new AcquisitionPointDto { 
                    PointName = pointName,
                    AcquisitionPointNo = int.Parse(pointNo),
                    AcquisitionIndex = int.Parse(pointIndex),
                    PointDesc = pointDesc,
                    ProcedureType = int.Parse(pointType),
                    AcquisitionDeviceNo = int.Parse(deviceNo)
                };

                if (id.Equals(""))
                {
                    // 新建
                    _procedureAppService.createPoint(point);
                }
                else
                {
                    // 更新
                    point.Id = int.Parse(id);
                    _procedureAppService.updatePoint(point);
    
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

        private void kryptonHeaderGroup2_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
