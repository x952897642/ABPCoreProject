using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPCoreProject.MultiTenancy.Dto;

namespace ABPCoreProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

