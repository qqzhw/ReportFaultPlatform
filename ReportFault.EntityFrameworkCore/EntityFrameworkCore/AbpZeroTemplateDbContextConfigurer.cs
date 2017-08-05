using Microsoft.EntityFrameworkCore;

namespace ReportFault.EntityFrameworkCore
{
    public static class ReportFaultDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ReportFaultDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString,c=>c.UseRowNumberForPaging());
        }
    }
}