using System.ComponentModel.DataAnnotations;

namespace Webapplication2.Controllers.Auth
{
    public class RegisterViewModel
    {
        [Required]
        public string Username;
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(5)][MaxLength(36)]
        public string Password { get; set; }
    }
}