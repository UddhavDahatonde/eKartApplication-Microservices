using Microsoft.AspNetCore.Identity;

namespace Auth.Core.Domain.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole()
        { }
        public ApplicationRole(string role) : base(role)
        { }
    }
}
