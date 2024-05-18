using Product.Core.Domain.Entities;
using Product.Core.Domain.RepositeryContract;
using Product.Infrastructure.DataContext;

namespace Product.Infrastructure.Repositery
{
    public class CategoryRepositery : GenericRepository<Category>, ICategoryRepositery
    {
        public CategoryRepositery(AppDbContext Context) : base(Context)
        {

        }

    }
}
