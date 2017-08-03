using Abp.AspNetCore.Mvc.ViewComponents;

namespace ReportFault.Web.Views
{
    public abstract class ReportFaultViewComponent : AbpViewComponent
    {
        protected ReportFaultViewComponent()
        {
            LocalizationSourceName = ReportFaultConsts.LocalizationSourceName;
        }
    }
}