using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyTest.EntityFrameworkCore;
using MyTest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyTest.Web.Tests
{
    [DependsOn(
        typeof(MyTestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyTestWebTestModule : AbpModule
    {
        public MyTestWebTestModule(MyTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyTestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyTestWebMvcModule).Assembly);
        }
    }
}