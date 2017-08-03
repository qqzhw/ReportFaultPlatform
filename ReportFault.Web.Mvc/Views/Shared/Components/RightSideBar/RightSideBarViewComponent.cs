using System.Linq;
using System.Threading.Tasks;
using Abp.Configuration;
using ReportFault.Configuration;
using ReportFault.Configuration.Ui;
using Microsoft.AspNetCore.Mvc;

namespace ReportFault.Web.Views.Shared.Components.RightSideBar
{
    public class RightSideBarViewComponent : ReportFaultViewComponent
    {
        private readonly ISettingManager _settingManager;

        public RightSideBarViewComponent(ISettingManager settingManager)
        {
            _settingManager = settingManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var themeName = await _settingManager.GetSettingValueAsync(AppSettingNames.UiTheme);

            var viewModel = new RightSideBarViewModel
            {
                CurrentTheme = UiThemes.All.FirstOrDefault(t => t.CssClass == themeName)
            };

            return View(viewModel);
        }
    }
}
