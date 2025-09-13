using Identity.Api.Models;

namespace Identity.Api.Services
{
    public interface IJwtService
    {
        string GenerateToken(ApplicationUser user, IList<string> roles);
    }
}
