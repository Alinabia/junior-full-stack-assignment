using LeanTask.Application.Interfaces.Common;
using LeanTask.Application.Requests.Identity;
using LeanTask.Application.Responses.Identity;
using LeanTask.Shared.Wrapper;
using System.Threading.Tasks;

namespace LeanTask.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}