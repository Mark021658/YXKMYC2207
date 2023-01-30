using System;
using Abp.Localization;
using Abp.Modules;
using System.Reflection;

namespace Abp.Modbus
{
    [DependsOn(typeof(AbpKernelModule))]
    public class AbpModbusModule : AbpModule
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