using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABPCoreProject.Controllers;

namespace ABPCoreProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPCoreProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
