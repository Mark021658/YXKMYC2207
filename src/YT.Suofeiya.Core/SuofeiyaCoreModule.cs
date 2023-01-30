using Abp.Modules;
using Abp.Reflection.Extensions;
using YT.Suofeiya.Localization;

namespace YT.Suofeiya
{
    public class SuofeiyaCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            SuofeiyaLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SuofeiyaCoreModule).GetAssembly());
        }
    }
}