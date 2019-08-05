using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPCoreProject.Configuration.Dto;

namespace ABPCoreProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPCoreProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
