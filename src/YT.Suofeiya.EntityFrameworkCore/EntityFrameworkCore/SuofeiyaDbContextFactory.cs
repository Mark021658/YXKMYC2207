using YT.Suofeiya.Configuration;
using YT.Suofeiya.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace YT.Suofeiya.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class SuofeiyaDbContextFactory : IDesignTimeDbContextFactory<SuofeiyaDbContext>
    {
        public SuofeiyaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SuofeiyaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(SuofeiyaConsts.ConnectionStringName)
            );

            return new SuofeiyaDbContext(builder.Options);
        }
    }
}