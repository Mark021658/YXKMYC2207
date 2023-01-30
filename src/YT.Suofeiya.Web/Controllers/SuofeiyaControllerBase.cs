using Abp.AspNetCore.Mvc.Controllers;

namespace YT.Suofeiya.Web.Controllers
{
    public abstract class SuofeiyaControllerBase: AbpController
    {
        protected SuofeiyaControllerBase()
        {
            LocalizationSourceName = SuofeiyaConsts.LocalizationSourceName;
        }
    }
}