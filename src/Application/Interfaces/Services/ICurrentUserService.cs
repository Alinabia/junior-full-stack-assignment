using LeanTask.Application.Interfaces.Common;

namespace LeanTask.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}