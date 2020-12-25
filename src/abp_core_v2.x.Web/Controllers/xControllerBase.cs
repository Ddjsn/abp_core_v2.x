using Abp.AspNetCore.Mvc.Controllers;

namespace abp_core_v2.x.Web.Controllers
{
    public abstract class xControllerBase: AbpController
    {
        protected xControllerBase()
        {
            LocalizationSourceName = xConsts.LocalizationSourceName;
        }
    }
}