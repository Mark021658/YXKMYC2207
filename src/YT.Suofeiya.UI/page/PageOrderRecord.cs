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

namespace YT.SuZhou.UI.Pages
{
    /// <summary>
    /// 下单 撤单 删除记录
    /// </summary>
    public partial class PageOrderRecord : UserControlBase
    {
        //private readonly IOrderOperateRecordAppService _orderOperateRecordAppService;

        public PageOrderRecord()
        {
            InitializeComponent();
            //_orderOperateRecordAppService = IocManager.Instance.Resolve<IOrderOperateRecordAppService>();
        }

        private void butQuery_Click(object sender, EventArgs e)
        {
            //如果id号不为空，就取查询id号
            if(tbID.Text != String.Empty)
            {
                //dgvOrderOperateRecord.DataSource = _orderOperateRecordAppService.Get(tbID.Text);
            }
            else
            {
                //dgvOrderOperateRecord.DataSource = _orderOperateRecordAppService.GetAll();
            }

        }
    }
}
