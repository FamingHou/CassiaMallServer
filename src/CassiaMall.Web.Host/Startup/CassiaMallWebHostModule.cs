using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CassiaMall.Configuration;

namespace CassiaMall.Web.Host.Startup
{
    [DependsOn(
       typeof(CassiaMallWebCoreModule))]
    public class CassiaMallWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CassiaMallWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CassiaMallWebHostModule).GetAssembly());
        }
    }
}
