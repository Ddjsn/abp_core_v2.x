using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace abp_core_v2.x.EntityFrameworkCore
{
    [DependsOn(
        typeof(xCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class xEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(xEntityFrameworkCoreModule).GetAssembly());
        }
    }
}