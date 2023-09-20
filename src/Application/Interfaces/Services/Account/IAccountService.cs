using LeanTask.Application.Interfaces.Common;
using LeanTask.Application.Requests.Identity;
using LeanTask.Shared.Wrapper;
using System.Threading.Tasks;

namespace LeanTask.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}