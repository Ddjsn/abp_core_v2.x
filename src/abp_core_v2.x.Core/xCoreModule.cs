using Abp.Modules;
using Abp.Reflection.Extensions;
using abp_core_v2.x.Localization;

namespace abp_core_v2.x
{
    public class xCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            xLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(xCoreModule).GetAssembly());
        }
    }
}