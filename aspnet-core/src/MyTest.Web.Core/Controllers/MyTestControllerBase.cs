using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyTest.Controllers
{
    public abstract class MyTestControllerBase: AbpController
    {
        protected MyTestControllerBase()
        {
            LocalizationSourceName = MyTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
