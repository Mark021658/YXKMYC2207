using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YT.SuZhou.Tool;
using Abp.Dependency;
using YT.SuZhou.Core.PLC;
using System.IO;
using YT.SuZhou.Core.Procedure;

namespace YT.SuZhou.UI.Pages
{
    public partial class PageInMakingDev : UserControl
    {
        private readonly IToolAppService _toolAppService;

        public PageInMakingDev()
        {
            InitializeComponent();
            _toolAppService = IocManager.Instance.Resolve<IToolAppService>();
        }

        private void PageInMakingDev_Load(object sender, EventArgs e)
        {
            //生成 treeview 视图
            List<ProcedureEntity> listDevName = _toolAppService.GetProcessName();

            string imagePath = System.IO.Path.Combine(@"D:\jili\mes\JC\icon\设备\设备.png");

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

                //devListBox1.Items.Add(item1);
            }
        }
    }
}
