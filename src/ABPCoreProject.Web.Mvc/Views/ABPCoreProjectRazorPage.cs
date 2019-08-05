using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace ABPCoreProject.Web.Views
{
    public abstract class ABPCoreProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ABPCoreProjectRazorPage()
        {
            LocalizationSourceName = ABPCoreProjectConsts.LocalizationSourceName;
        }
    }
}
