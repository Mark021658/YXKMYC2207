using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YT.Suofeiya.Core.Alarm;
using YT.Suofeiya.Core.Menu;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Procedure;
using YT.Suofeiya.Core.Status;
using YT.Suofeiya.Core.Tool;
using YT.Suofeiya.DataAcquistion.Energy;
using YT.Suofeiya.Line;
using YT.Suofeiya.Order;
using YT.Suofeiya.Core.Operation;
using Abp.Domain.Repositories;
using YT.Suofeiya.EntityFrameworkCore.Repositories;

namespace YT.Suofeiya.EntityFrameworkCore
{
    public class SuofeiyaSecondDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public virtual DbSet<OuterTaskInfoEntity> TaskInfoDbSet { get; set; }

        public SuofeiyaSecondDbContext(DbContextOptions<SuofeiyaSecondDbContext> options) 
            : base(options)
        {
        }
       
    }
}
