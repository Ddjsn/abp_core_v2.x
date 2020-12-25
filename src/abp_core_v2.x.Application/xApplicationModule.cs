using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace abp_core_v2.x
{
    [DependsOn(
        typeof(xCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class xApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(xApplicationModule).GetAssembly());
        }
    }
}