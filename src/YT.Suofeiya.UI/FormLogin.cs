using Abp.Dependency;
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

namespace YT.Suofeiya.UI
{
    public partial class FormLogin : KryptonForm, ITransientDependency
    {
        
        public string LoginUser = "";

        public FormLogin()
        {
            InitializeComponent();

            //_accountService = accountService;

            //ISessionAppService sessionAppService, IUserAppService userAppService

            //_sessionAppService = IocManager.Instance.Resolve<ISessionAppService>();

            //_userAppService = IocManager.Instance.Resolve <IUserAppService>();
            //_orderAppService = IocManager.Instance.Resolve<IOrderAppService>();
            LoginUser = "";
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            LoginUser = UserTb.Text;
            Close();
           
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            LoginUser = UserTb.Text;
            Close();
        }
    }
}
