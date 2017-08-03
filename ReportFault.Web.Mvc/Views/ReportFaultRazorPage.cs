using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ReportFault.Web.Views
{
    public abstract class ReportFaultRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ReportFaultRazorPage()
        {
            LocalizationSourceName = ReportFaultConsts.LocalizationSourceName;
        }
    }
}
