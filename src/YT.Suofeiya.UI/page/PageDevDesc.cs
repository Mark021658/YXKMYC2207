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
using YT.SuZhou.Tool;
using YT.SuZhou.Core.PLC;
using System.IO;
using YT.SuZhou.Core.Procedure;

namespace YT.SuZhou.UI.Pages
{
    public partial class PageDevDesc : UserControlBase
    {
        private readonly IToolAppService _toolAppService;

        public PageDevDesc()
        {
            InitializeComponent();

            _toolAppService = IocManager.Instance.Resolve<IToolAppService>();
        }

        private void PageDevDesc_Load(object sender, EventArgs e)
        {
            dataDgv.Rows.Add();
            dataDgv.Rows[0].Cells[0].Value = "2010/10/27";
            dataDgv.Rows[0].Cells[1].Value = "小张";
            dataDgv.Rows[0].Cells[3].Value = "对射开关开关损坏";
            dataDgv.Rows[0].Cells[2].Value = "机台1";
            dataDgv.Rows[0].Cells[4].Value = "对射开关";
            //生成 treeview 视图
            List<ProcedureEntity> listDevName = _toolAppService.GetProcessName();

            string imagePath = Path.Combine(@"D:\jili\mes\JC\icon\设备\设备.png");

            Bitmap image = null;
            if (File.Exists(imagePath))
            {
                image = new Bitmap(imagePath);
            }

            foreach (var processName in listDevName)
            {
                var item1 = new System.ComponentModel.Design.ListBoxItem()
                {
                    No = processName.ProcedureNo.ToString(),
                    Id = Guid.NewGuid(),
                    Desc = processName.Desc,
                    Name = processName.ProcedureName,
                    Image = image,
                };

                devListBox1.Items.Add(item1);
            }
        }
    }
}
