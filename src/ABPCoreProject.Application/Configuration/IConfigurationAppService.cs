using System.Threading.Tasks;
using ABPCoreProject.Configuration.Dto;

namespace ABPCoreProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
