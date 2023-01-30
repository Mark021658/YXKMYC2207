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
using YT.Suofeiya.Alarm;
using YT.Suofeiya.DataAcquistion.Procedure.Dto;
using YT.Suofeiya.Procedure;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageAlarmManage : UserControlBase
    {

        private readonly IAlarmAppService _alarmAppService;
        private readonly IProcedureAppService _procedureAppService;

        List<AlarmDto> listAlarm;
        List<AcquisitionPointDto> listPoint;
        public PageAlarmManage()
        {
            _alarmAppService = IocManager.Instance.Resolve<IAlarmAppService>();
            _procedureAppService = IocManager.Instance.Resolve<IProcedureAppService>();
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            // 刷新列表
            listAlarm = _alarmAppService.GetAll().ToList();
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.DataSource = listAlarm;

            listPoint = _procedureAppService.GetPointName();
            this.kcb_pointNo.DataSource = listPoint;
            this.kcb_pointNo.DisplayMember = "PointName";
            this.kcb_pointNo.ValueMember = "AcquisitionPointNo";

            cleanTextBox();

        }

        // 清空编辑框
        public void cleanTextBox()
        {
            ktb_faultNo.Text = "";
            ktb_alarmType.Text = "";
            ktb_name.Text = "";
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
                        string pointNo = kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionPointNo"].Value.ToString();
                        kcb_pointNo.SelectedItem = new AcquisitionPointDto { AcquisitionPointNo = int.Parse(pointNo) };
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["FaultNo"].Value != null)
                    { 
                        ktb_faultNo.Text = kryptonDataGridView1.Rows[rowIndex].Cells["FaultNo"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["AlarmType"].Value != null)
                    { 
                        ktb_alarmType.Text = kryptonDataGridView1.Rows[rowIndex].Cells["AlarmType"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["AName"].Value != null)
                    { 
                        ktb_name.Text = kryptonDataGridView1.Rows[rowIndex].Cells["AName"].Value.ToString();
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
                string faultNo = ktb_faultNo.Text;
                string alarmType = ktb_alarmType.Text;
                string alarmName = ktb_name.Text;
                AlarmDto alarm = new AlarmDto
                { 
                    Name    = alarmName,
                    AcquisitionPointNo = int.Parse(pointNo),
                    FaultNo = int.Parse(faultNo),
                    AlarmType = int.Parse(alarmType)
                };

                if (id.Equals(""))
                {
                    // 新建
                    _alarmAppService.createAlarm(alarm);
                }
                else
                {
                    // 更新
                    alarm.Id = int.Parse(id);
                    _alarmAppService.updateAlarm(alarm);
    
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
