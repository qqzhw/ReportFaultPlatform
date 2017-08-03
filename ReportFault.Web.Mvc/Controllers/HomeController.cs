using Abp.AspNetCore.Mvc.Authorization;
using ReportFault.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ReportFault.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ReportFaultControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}