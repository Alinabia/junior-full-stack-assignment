using LeanTask.Application.Requests;

namespace LeanTask.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}