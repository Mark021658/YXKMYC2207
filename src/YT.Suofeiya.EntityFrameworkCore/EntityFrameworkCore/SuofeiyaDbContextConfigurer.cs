using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace YT.Suofeiya.EntityFrameworkCore
{
    public static class SuofeiyaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SuofeiyaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SuofeiyaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
