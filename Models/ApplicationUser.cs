using Microsoft.AspNetCore.Identity;

namespace Identity.Api.Models
{
    // The ApplicationUser class extends IdentityUser to add a Role property.
    public class ApplicationUser : IdentityUser
    {
        // Add your custom properties here.
        public string Role { get; set; } = string.Empty;
    }
}
