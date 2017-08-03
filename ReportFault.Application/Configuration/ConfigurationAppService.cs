using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ReportFault.Configuration.Dto;

namespace ReportFault.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ReportFaultAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
