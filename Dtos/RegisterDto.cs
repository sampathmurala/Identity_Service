// DTO for user registration requests.
// It contains only the fields necessary for a new user to sign up.
using System.ComponentModel.DataAnnotations;

namespace Identity.Api.Dtos
{
    public class RegisterUserDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
