using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YT.Suofeiya.Configuration;
using YT.Suofeiya.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace YT.Suofeiya.Web.Startup
{
    [DependsOn(
        typeof(SuofeiyaApplicationModule), 
        typeof(SuofeiyaEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class SuofeiyaWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SuofeiyaWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(SuofeiyaConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<SuofeiyaNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(SuofeiyaApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SuofeiyaWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SuofeiyaWebModule).Assembly);
        }
    }
}
