using Microsoft.EntityFrameworkCore;

namespace YT.Suofeiya.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<SuofeiyaDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for SuofeiyaDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }

        public static void Configure(
            DbContextOptionsBuilder<SuofeiyaSecondDbContext> dbContextOptions,
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for SuofeiyaDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
