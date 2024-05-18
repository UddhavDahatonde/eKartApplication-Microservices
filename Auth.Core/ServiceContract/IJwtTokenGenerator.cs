using Auth.Core.Domain.Entities;

namespace Auth.Core.ServiceContract
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
