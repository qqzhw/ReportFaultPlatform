using Abp.Zero.EntityFrameworkCore;
using ReportFault.Authorization.Roles;
using ReportFault.Authorization.Users;
using ReportFault.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace ReportFault.EntityFrameworkCore
{
    public class ReportFaultDbContext : AbpZeroDbContext<Tenant, Role, User, ReportFaultDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public ReportFaultDbContext(DbContextOptions<ReportFaultDbContext> options)
            : base(options)
        {

        }
    }
}
