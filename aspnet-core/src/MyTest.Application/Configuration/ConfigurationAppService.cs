using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyTest.Configuration.Dto;

namespace MyTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
