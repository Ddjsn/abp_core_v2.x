using Abp.AspNetCore.Mvc.Views;

namespace abp_core_v2.x.Web.Views
{
    public abstract class xRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected xRazorPage()
        {
            LocalizationSourceName = xConsts.LocalizationSourceName;
        }
    }
}
