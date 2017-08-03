using System.Collections.Generic;
using ReportFault.Roles.Dto;
using ReportFault.Users.Dto;

namespace ReportFault.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}