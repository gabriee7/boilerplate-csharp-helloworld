using System.Threading.Tasks;
using Abp.Application.Services;
using MyTest.Sessions.Dto;

namespace MyTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
