using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPCoreProject.Configuration;

namespace ABPCoreProject.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPCoreProjectWebCoreModule))]
    public class ABPCoreProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPCoreProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPCoreProjectWebHostModule).GetAssembly());
        }
    }
}
