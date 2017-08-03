using ReportFault.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ReportFault.Web.Controllers
{
    public class AboutController : ReportFaultControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}