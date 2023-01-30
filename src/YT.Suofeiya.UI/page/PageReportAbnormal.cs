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
using YT.Suofeiya.Order;
using YT.Suofeiya.Order.Dto;

namespace YT.Suofeiya.UI.Page
{
    public partial class PageReportAbnormal : UserControlBase
    {
        private readonly IOrderAppService _orderAppService;

        public PageReportAbnormal()
        {
            InitializeComponent();
            _orderAppService = IocManager.Instance.Resolve<IOrderAppService>();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //IOrderAppService _orderAppService = IocManager.Instance.Resolve<IOrderAppService>();
            dataGridView1.DataSource = _orderAppService.GetHisAbnormal(dateTimePicker1.Value.Date, dateTimePicker2.Value);

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //IOrderAppService _orderAppService = IocManager.Instance.Resolve<IOrderAppService>();
            AbnormalDto Abnormalset = new AbnormalDto();
            //List<bujian> bujiansets = new List<bujian>();
            //Abnormalset.RequestCode = request10.RequestCode;
            //Abnormalset.LineCode = request10.LineCode;
            //Abnormalset.OperationCode = request10.OperationCode;
            //Abnormalset.OperationShortName = request10.OperationShortName;
            //Abnormalset.EventCode = 0;
            Abnormalset.PalletCode = kryptonTextBox3.Text;
            Abnormalset.MaterialCode = kryptonTextBox1.Text;
            //Abnormalset.ProductionBatchCode = "";
            Abnormalset.NOKQuantity = Convert.ToInt32(numericUpDown1.Value);
            //Abnormalset.NOKSets = bujiansets;
            //Abnormalset.ScrappedQuantity = 0;
            //Abnormalset.ScrappedSets = bujiansets;
            //Abnormalset.RequestTime = request10.RequestTime;

            try
            {
                _orderAppService.ReportAbnormal(Abnormalset);
                kryptonLabel6.Visible = false;
                kryptonTextBox1.Text = "";
                kryptonTextBox3.Text = ""; 
            }
            catch
            {
                kryptonLabel6.Visible = true;
            }

            richTextBox1.Focus();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] ScanList = richTextBox1.Text.Split('@');


            switch (ScanList[0])
            {
                case "QRPART":
                    kryptonTextBox1.Text = ScanList[1];
                    break;
                case "QRTOLT":
                    kryptonTextBox3.Text = ScanList[1];
                    break;
            }


            //    "QRPART"
        }
    }
}
