using System.Collections.Generic;
using System.Threading.Tasks;
using LeanTask.Application.Interfaces.Common;
using LeanTask.Application.Requests.Identity;
using LeanTask.Application.Responses.Identity;
using LeanTask.Shared.Wrapper;

namespace LeanTask.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}