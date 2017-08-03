using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReportFault.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ReportFault.Web.Host.Startup
{
    [DependsOn(
       typeof(ReportFaultWebCoreModule))]
    public class ReportFaultWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReportFaultWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReportFaultWebHostModule).GetAssembly());
        }
    }
}
