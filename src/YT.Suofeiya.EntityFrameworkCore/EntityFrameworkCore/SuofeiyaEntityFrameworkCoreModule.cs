using Abp.EntityFrameworkCore.Configuration;
using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace YT.Suofeiya.EntityFrameworkCore
{
    [DependsOn(
        typeof(SuofeiyaCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class SuofeiyaEntityFrameworkCoreModule : AbpModule
    {

        public bool SkipDbContextRegistration { get; set; }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpConfiguration.DefaultNameOrConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            
            Configuration.Modules.AbpEfCore().AddDbContext<SuofeiyaDbContext>(options =>
            {
                options.DbContextOptions.UseSqlServer(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
                //DbContextOptionsConfigurer.Configure(options.DbContextOptions, ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
            });

            Configuration.Modules.AbpEfCore().AddDbContext<SuofeiyaSecondDbContext>(options => {
                options.DbContextOptions.UseSqlServer(ConfigurationManager.ConnectionStrings["Second"].ConnectionString);
            });

            Configuration.Modules.AbpEfCore().AddDbContext<SuofeiyaMySqlDbContext>(options => {
                options.DbContextOptions.UseMySql(ConfigurationManager.ConnectionStrings["MySql"].ConnectionString);
            });

        }
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}