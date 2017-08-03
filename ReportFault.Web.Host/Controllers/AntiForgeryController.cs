using ReportFault.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace ReportFault.Web.Host.Controllers
{
    public class AntiForgeryController : ReportFaultControllerBase
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