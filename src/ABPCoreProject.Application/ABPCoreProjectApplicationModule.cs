using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPCoreProject.Authorization;

namespace ABPCoreProject
{
    [DependsOn(
        typeof(ABPCoreProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPCoreProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPCoreProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPCoreProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
