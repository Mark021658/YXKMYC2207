using Abp;
using Abp.Castle.Logging.Log4Net;
using Castle.Facilities.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YT.Suofeiya.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var bootstrapper = AbpBootstrapper.Create<YTWinFormUiModule>())
            {
                bootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(f => f.UseAbpLog4Net().WithConfig("log4net.config"));
                //bootstrapper.IocManager.IocContainer.AddFacility

                //bootstrapper
                bootstrapper.Initialize();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(bootstrapper.IocManager.Resolve<FormMain>());
            }
        }
    }
}
