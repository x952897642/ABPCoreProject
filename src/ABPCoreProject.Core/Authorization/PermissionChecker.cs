using Abp.Authorization;
using ABPCoreProject.Authorization.Roles;
using ABPCoreProject.Authorization.Users;

namespace ABPCoreProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
