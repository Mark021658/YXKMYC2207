using Abp.AspNetCore.Mvc.Views;

namespace YT.Suofeiya.Web.Views
{
    public abstract class SuofeiyaRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected SuofeiyaRazorPage()
        {
            LocalizationSourceName = SuofeiyaConsts.LocalizationSourceName;
        }
    }
}
