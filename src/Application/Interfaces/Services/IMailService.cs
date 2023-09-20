using LeanTask.Application.Requests.Mail;
using System.Threading.Tasks;

namespace LeanTask.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}