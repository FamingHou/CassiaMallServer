using Abp.Application.Services;
using CassiaMall.MultiTenancy.Dto;

namespace CassiaMall.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

