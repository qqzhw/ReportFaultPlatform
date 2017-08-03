using System.Threading.Tasks;
using ReportFault.Configuration.Dto;

namespace ReportFault.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}