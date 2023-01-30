using Abp.Application.Services;

namespace YT.Suofeiya
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SuofeiyaAppServiceBase : ApplicationService
    {
        protected SuofeiyaAppServiceBase()
        {
            LocalizationSourceName = SuofeiyaConsts.LocalizationSourceName;
        }
    }
}