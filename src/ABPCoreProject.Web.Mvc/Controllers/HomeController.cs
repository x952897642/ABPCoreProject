using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABPCoreProject.Controllers;
using ABPCoreProject.Web.Views.Shared.Components.SideBarNav;
using Abp.Application.Navigation;
using Abp.Threading;
using Abp.Runtime.Session;

namespace ABPCoreProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPCoreProjectControllerBase
    {
        private readonly IUserNavigationManager _userNavigationManager;

        public HomeController(
            IUserNavigationManager userNavigationManager)
        {
            _userNavigationManager = userNavigationManager;
        }
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult IndexAdmin()
        {
            var model = new SideBarNavViewModel
            {
                MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", AbpSession.ToUserIdentifier()))
            };
            return PartialView("IndexAdmin", model);
        }
    }
}
