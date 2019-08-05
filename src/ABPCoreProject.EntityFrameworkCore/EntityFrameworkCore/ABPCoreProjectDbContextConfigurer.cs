using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPCoreProject.EntityFrameworkCore
{
    public static class ABPCoreProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPCoreProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPCoreProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
