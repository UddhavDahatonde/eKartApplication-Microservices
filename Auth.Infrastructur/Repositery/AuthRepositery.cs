using Auth.Core.Domain.Entities;
using Auth.Core.Domain.RepositeryContract;
using Auth.Infrastructure.DataContext;

namespace Auth.Infrastructure.Repositery
{
    public class AuthRepositery : GenericRepository<ApplicationUser>, IAuthRepositery
    {
        public AuthRepositery(AppDbContext Context) : base(Context)
        {

        }
    }
}
