using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCoreProject.Sessions.Dto;

namespace ABPCoreProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
