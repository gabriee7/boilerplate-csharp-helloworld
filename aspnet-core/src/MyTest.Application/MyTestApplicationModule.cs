using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyTest.Authorization;

namespace MyTest
{
    [DependsOn(
        typeof(MyTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
