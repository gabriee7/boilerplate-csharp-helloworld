using System.Threading.Tasks;
using MyTest.Configuration.Dto;

namespace MyTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
