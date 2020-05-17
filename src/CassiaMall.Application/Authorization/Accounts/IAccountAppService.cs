using System.Threading.Tasks;
using Abp.Application.Services;
using CassiaMall.Authorization.Accounts.Dto;

namespace CassiaMall.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
