// DTO for user login requests.
// Contains only the fields required for authentication.
using System.ComponentModel.DataAnnotations;

namespace Identity.Api.Dtos
{
    public class LoginUserDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
