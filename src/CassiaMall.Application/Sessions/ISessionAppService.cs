using System.Threading.Tasks;
using Abp.Application.Services;
using CassiaMall.Sessions.Dto;

namespace CassiaMall.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
