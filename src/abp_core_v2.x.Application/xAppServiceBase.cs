using Abp.Application.Services;

namespace abp_core_v2.x
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class xAppServiceBase : ApplicationService
    {
        protected xAppServiceBase()
        {
            LocalizationSourceName = xConsts.LocalizationSourceName;
        }
    }
}