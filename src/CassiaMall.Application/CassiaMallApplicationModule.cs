using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CassiaMall.Authorization;

namespace CassiaMall
{
    [DependsOn(
        typeof(CassiaMallCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CassiaMallApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CassiaMallAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CassiaMallApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
