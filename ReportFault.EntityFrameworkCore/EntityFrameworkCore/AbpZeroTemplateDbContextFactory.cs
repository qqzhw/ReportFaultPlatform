using ReportFault.Configuration;
using ReportFault.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace ReportFault.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ReportFaultDbContextFactory : IDbContextFactory<ReportFaultDbContext>
    {
        public ReportFaultDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<ReportFaultDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ReportFaultDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ReportFaultConsts.ConnectionStringName));
            
            return new ReportFaultDbContext(builder.Options);
        }
    }
}