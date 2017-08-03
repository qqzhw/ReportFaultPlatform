using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ReportFault.MultiTenancy.Dto;

namespace ReportFault.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
