using LeanTask.Shared.Wrapper;
using System.Threading.Tasks;
using LeanTask.Application.Features.Dashboards.Queries.GetData;

namespace LeanTask.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}