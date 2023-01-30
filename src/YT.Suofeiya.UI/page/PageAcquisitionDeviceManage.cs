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
    public partial class PageAcquisitionDeviceManage : UserControlBase
    {

        private readonly IProcedureAppService _procedureAppService;

        List<AcquisitionDeviceDto> listDevice;
        public PageAcquisitionDeviceManage()
        {
            _procedureAppService = IocManager.Instance.Resolve<IProcedureAppService>();
            InitializeComponent();

            kcb_communicationBox.Items.Add(new ComboBoxItem("ModbusTcp", 1));
            kcb_communicationBox.Items.Add(new ComboBoxItem("TCP", 2));
            kcb_communicationBox.DisplayMember = ComboBoxItem.NAME;
            kcb_communicationBox.ValueMember = ComboBoxItem.VALUE;

            refresh();
        }

        // 刷新列表
        public void refresh()
        {

            listDevice = _procedureAppService.GetPointDeviceList();
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.DataSource = listDevice;

            cleanTextBox();
        }

        //清空编辑框
        public void cleanTextBox()
        {
            ktb_deviceNo.Text = "";
            ktb_deviceIndex.Text = "";
            ktb_port.Text = "";
            ktb_ip.Text = "";
            ktb_ID.Text = "";
            ktb_Desc.Text = "";
            ktb_deviceName.Text = "";
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
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["deviceId"].Value != null)
                    { 
                        ktb_ID.Text = kryptonDataGridView1.Rows[rowIndex].Cells["deviceId"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["CommunicationMode"].Value != null)
                    {
                        string v = kryptonDataGridView1.Rows[rowIndex].Cells["CommunicationMode"].Value.ToString();
                        kcb_communicationBox.SelectedItem = new ComboBoxItem(v);
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionDeviceNo"].Value != null)
                    { 
                        ktb_deviceNo.Text = kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionDeviceNo"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionDeviceIndex"].Value != null)
                    { 
                        ktb_deviceIndex.Text = kryptonDataGridView1.Rows[rowIndex].Cells["AcquisitionDeviceIndex"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["DeviceName"].Value != null)
                    {
                        ktb_deviceName.Text = kryptonDataGridView1.Rows[rowIndex].Cells["DeviceName"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["Port"].Value != null)
                    { 
                        ktb_port.Text = kryptonDataGridView1.Rows[rowIndex].Cells["Port"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["IP"].Value != null)
                    { 
                        ktb_ip.Text = kryptonDataGridView1.Rows[rowIndex].Cells["IP"].Value.ToString();
                    }
                    if (kryptonDataGridView1.Rows[rowIndex].Cells["Desc"].Value != null)
                    { 
                        ktb_Desc.Text = kryptonDataGridView1.Rows[rowIndex].Cells["Desc"].Value.ToString();
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
                string commMode = ((ComboBoxItem)kcb_communicationBox.SelectedItem).value.ToString();
                string deviceNo = ktb_deviceNo.Text;
                string deviceIndex = ktb_deviceIndex.Text;
                string deviceName = ktb_deviceName.Text;
                string ip = ktb_ip.Text;
                string port = ktb_port.Text;
                string desc = ktb_Desc.Text;
                AcquisitionDeviceDto device = new AcquisitionDeviceDto
                { 
                    CommunicationMode = (EnumCommunicationMode)int.Parse(commMode),
                    AcquisitionDeviceNo = int.Parse(deviceNo),
                    AcquisitionDeviceIndex = int.Parse(deviceIndex),
                    Name = deviceName,
                    IP = ip,
                    Port =int.Parse(port),
                    Desc = desc
                };

                if (id.Equals(""))
                {
                    // 新建
                    _procedureAppService.createPoitDevice(device);
                }
                else
                {
                    // 更新
                    device.Id = int.Parse(id);
                    _procedureAppService.updatePointDevice(device);
    
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

        private void kryptonLabel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
