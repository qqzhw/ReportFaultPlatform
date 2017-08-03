using Abp.Authorization;
using ReportFault.Authorization.Roles;
using ReportFault.Authorization.Users;

namespace ReportFault.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
