using System.Collections.Generic;
using System.Threading.Tasks;
using LeanTask.Application.Requests.Identity;
using LeanTask.Application.Responses.Identity;
using LeanTask.Shared.Wrapper;

namespace LeanTask.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}