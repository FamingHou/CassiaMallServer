using System.Threading.Tasks;
using CassiaMall.Configuration.Dto;

namespace CassiaMall.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
