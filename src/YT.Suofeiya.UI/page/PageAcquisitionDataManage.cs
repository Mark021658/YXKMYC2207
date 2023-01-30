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
    public partial class PageAcquisitionDataManage : UserControlBase
    {

        private readonly IProcedureAppService _procedureAppService;

        List<AcquisitionDataDto> listPointData;
        List<AcquisitionPointDto> listPoint;
        public PageAcquisitionDataManage()
        {
            _procedureAppService = IocManager.Instance.Resolve<IProcedureAppService>();
            InitializeComponent();

            kcb_dataType.Items.Add(new ComboBoxItem("Status", 0));
            kcb_dataType.Items.Add(new ComboBoxItem("ScanRead", 9));
            kcb_dataType.Items.Add(new ComboBoxItem("ScanWrite", 10));
            kcb_dataType.DisplayMember = ComboBoxItem.NAME;
            kcb_dataType.ValueMember = ComboBoxItem.VALUE;

            this.refresh();
        }

        // 刷新列表
        public void refresh()
        {
            
            listPointData = _procedureAppService.GetPointDataList();
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.DataSource = listPointData;

            listPoint = _procedureAppService.GetPointName();
            this.kcb_pointNo.DataSource = listPoint;
            this.kcb_pointNo.DisplayMember = "PointName";
            this.kcb_pointNo.ValueMember = "AcquisitionPointNo";
            

            cleanTextBox();

        }

        // 清空编辑框
        public void cleanTextBox()
        {
            ktb_startAddr.Text = "";
            ktb_words.Text = "";
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
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["dataId"].Value != null)
                    { 
                        ktb_ID.Text = kryptonDataGridView1.Rows[rowIndex].Cells["dataId"].Value.ToString();
                    
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionPointNo"].Value != null)
                    { 
                        string pointNo = kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionPointNo"].Value.ToString();
                        kcb_pointNo.SelectedItem = new AcquisitionPointDto { AcquisitionPointNo = int.Parse(pointNo) };
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["StartAddr"].Value != null)
                    { 
                        ktb_startAddr.Text = kryptonDataGridView1.Rows[rowIndex].Cells["StartAddr"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["Words"].Value != null)
                    { 
                        ktb_words.Text = kryptonDataGridView1.Rows[rowIndex].Cells["Words"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["DataType"].Value != null)
                    {
                        string v = kryptonDataGridView1.Rows[rowIndex].Cells["DataType"].Value.ToString();
                        kcb_dataType.SelectedItem = new ComboBoxItem(v);
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
                string startAddr = ktb_startAddr.Text;
                string words = ktb_words.Text;
                string pointNo = kcb_pointNo.SelectedValue.ToString();
                string dataType = ((ComboBoxItem)kcb_dataType.SelectedItem).value.ToString();
                AcquisitionDataDto data = new AcquisitionDataDto { 
                    AcquisitionPointNo = int.Parse(pointNo),
                    StartAddr = int.Parse(startAddr),
                    Words = int.Parse(words),
                    DataType = (EnumDataType)int.Parse(dataType)
                };

                if (id.Equals(""))
                {
                    // 新建
                    _procedureAppService.createPointData(data);
                }
                else
                {
                    // 更新
                    data.Id = int.Parse(id);
                    _procedureAppService.updatePointData(data);
    
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
    }
}
