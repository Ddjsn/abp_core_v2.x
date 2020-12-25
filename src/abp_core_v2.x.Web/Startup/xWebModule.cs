using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using abp_core_v2.x.Configuration;
using abp_core_v2.x.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace abp_core_v2.x.Web.Startup
{
    [DependsOn(
        typeof(xApplicationModule), 
        typeof(xEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class xWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public xWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(xConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<xNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(xApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(xWebModule).GetAssembly());
        }
    }
}