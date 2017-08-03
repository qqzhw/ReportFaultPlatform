using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ReportFault.Roles.Dto;
using ReportFault.Users.Dto;

namespace ReportFault.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}