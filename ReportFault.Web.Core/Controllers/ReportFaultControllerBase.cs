using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ReportFault.Controllers
{
    public abstract class ReportFaultControllerBase: AbpController
    {
        protected ReportFaultControllerBase()
        {
            LocalizationSourceName = ReportFaultConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}