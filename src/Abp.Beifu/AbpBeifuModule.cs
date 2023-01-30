using Abp.Modules;
using System.Reflection;

namespace Abp.Beifu
{
    //[DependsOn(typeof(AbpKernelModule))]
    public class AbpBeifuModule : AbpModule
    {
        public override void PreInitialize()
        {

        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }

        public override void PostInitialize()
        {

        }
    }
}
