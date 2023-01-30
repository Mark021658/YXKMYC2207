using Abp.Modules;
using System.Configuration;
using System.Reflection;
using YT.Suofeiya;
using YT.Suofeiya.EntityFrameworkCore;

namespace YT.Suofeiya.UI
{
    [DependsOn(typeof(SuofeiyaEntityFrameworkCoreModule),
        typeof(SuofeiyaCoreModule),
        typeof(SuofeiyaApplicationModule))]
    public class YTWinFormUiModule : AbpModule
    {

        public override void PreInitialize()
        {
            Configuration.MultiTenancy.IsEnabled = false;
            Configuration.Auditing.IsEnabled = false;
        }
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
