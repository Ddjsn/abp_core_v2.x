using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abp_core_v2.x.Web.Startup;
namespace abp_core_v2.x.Web.Tests
{
    [DependsOn(
        typeof(xWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class xWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(xWebTestModule).GetAssembly());
        }
    }
}