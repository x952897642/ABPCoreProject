using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPCoreProject.Configuration;
using ABPCoreProject.Web;

namespace ABPCoreProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPCoreProjectDbContextFactory : IDesignTimeDbContextFactory<ABPCoreProjectDbContext>
    {
        public ABPCoreProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPCoreProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPCoreProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPCoreProjectConsts.ConnectionStringName));

            return new ABPCoreProjectDbContext(builder.Options);
        }
    }
}
