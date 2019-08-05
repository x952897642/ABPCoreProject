using Microsoft.AspNetCore.Antiforgery;
using ABPCoreProject.Controllers;

namespace ABPCoreProject.Web.Host.Controllers
{
    public class AntiForgeryController : ABPCoreProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
