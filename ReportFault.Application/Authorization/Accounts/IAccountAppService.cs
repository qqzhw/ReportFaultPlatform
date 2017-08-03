using System.Threading.Tasks;
using Abp.Application.Services;
using ReportFault.Authorization.Accounts.Dto;

namespace ReportFault.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
