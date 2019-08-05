using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPCoreProject.Authorization.Roles;
using ABPCoreProject.Authorization.Users;
using ABPCoreProject.MultiTenancy;

namespace ABPCoreProject.EntityFrameworkCore
{
    public class ABPCoreProjectDbContext : AbpZeroDbContext<Tenant, Role, User, ABPCoreProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPCoreProjectDbContext(DbContextOptions<ABPCoreProjectDbContext> options)
            : base(options)
        {
        }
    }
}
