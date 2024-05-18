using Product.Core.Domain.Entities;
using Product.Core.Domain.RepositeryContract;
using Product.Infrastructure.DataContext;

namespace Product.Infrastructure.Repositery
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(AppDbContext Context) : base(Context)
        {
        }

    }
}
