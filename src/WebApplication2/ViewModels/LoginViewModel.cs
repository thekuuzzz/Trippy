using System.ComponentModel.DataAnnotations;
using WebApplication2.Models;

namespace Webapplication2
{
    public class LoginViewModel
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
    }
}