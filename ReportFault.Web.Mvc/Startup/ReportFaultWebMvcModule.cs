using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReportFault.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ReportFault.Web.Startup
{
    [DependsOn(typeof(ReportFaultWebCoreModule))]
    public class ReportFaultWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReportFaultWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ReportFaultNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReportFaultWebMvcModule).GetAssembly());
        }
    }
}