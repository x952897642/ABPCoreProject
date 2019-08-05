using Abp.AspNetCore.Mvc.ViewComponents;

namespace ABPCoreProject.Web.Views
{
    public abstract class ABPCoreProjectViewComponent : AbpViewComponent
    {
        protected ABPCoreProjectViewComponent()
        {
            LocalizationSourceName = ABPCoreProjectConsts.LocalizationSourceName;
        }
    }
}
