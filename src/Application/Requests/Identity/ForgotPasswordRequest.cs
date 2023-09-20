using System.ComponentModel.DataAnnotations;

namespace LeanTask.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}