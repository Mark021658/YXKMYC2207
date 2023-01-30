using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT.Suofeiya.Core.Tool;

namespace YT.Suofeiya.UI
{
    public partial class FormToolChange : KryptonForm
    {
        public FormToolChange()
        {
            InitializeComponent();
        }

        public string ID { get; set; }
        public string PointNo { get; set; }
        public string ToolName { get; set; }
        public string ToolNo { get; set; }
        public string OperatorName { get; set; }
        public string Remarks { get; set; }
        public bool IsClear { get; set; }

        private void FormToolChange_Load(object sender, EventArgs e)
        {
            tbID.Text = ID;
            tbProcedureNo.Text = PointNo;
            tbToolNo.Text = ToolNo;
            tbToolName.Text = ToolName;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            OperatorName = tbOperatorName.Text;
            Remarks = tbRemarks.Text;
            IsClear = clearCb.Checked;
        }
    }
}
