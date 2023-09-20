using LeanTask.Client.Infrastructure.Extensions;
using LeanTask.Shared.Wrapper;
using System.Net.Http;
using System.Threading.Tasks;
using LeanTask.Application.Features.Dashboards.Queries.GetData;

namespace LeanTask.Client.Infrastructure.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly HttpClient _httpClient;

        public DashboardManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<DashboardDataResponse>> GetDataAsync()
        {
            var response = await _httpClient.GetAsync(Routes.DashboardEndpoints.GetData);
            var data = await response.ToResult<DashboardDataResponse>();
            return data;
        }
    }
}