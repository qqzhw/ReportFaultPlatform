using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using ReportFault.MultiTenancy;
using Abp.Runtime.Session;
using Abp.IdentityFramework;
using ReportFault.Authorization.Users;
using Microsoft.AspNetCore.Identity;

namespace ReportFault
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ReportFaultAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected ReportFaultAppServiceBase()
        {
            LocalizationSourceName = ReportFaultConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}