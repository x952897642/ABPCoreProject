using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPCoreProject.Controllers
{
    public abstract class ABPCoreProjectControllerBase: AbpController
    {
        protected ABPCoreProjectControllerBase()
        {
            LocalizationSourceName = ABPCoreProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
