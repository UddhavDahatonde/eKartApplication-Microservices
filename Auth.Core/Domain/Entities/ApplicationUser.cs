using Microsoft.AspNetCore.Identity;

namespace Auth.Core.Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? Name { get; set; }
    }
}
