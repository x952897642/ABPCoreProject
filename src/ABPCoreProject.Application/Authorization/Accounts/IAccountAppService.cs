using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCoreProject.Authorization.Accounts.Dto;

namespace ABPCoreProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
