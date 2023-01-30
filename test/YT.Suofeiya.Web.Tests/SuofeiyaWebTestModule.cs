using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YT.Suofeiya.Web.Startup;
namespace YT.Suofeiya.Web.Tests
{
    [DependsOn(
        typeof(SuofeiyaWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class SuofeiyaWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SuofeiyaWebTestModule).GetAssembly());
        }
    }
}