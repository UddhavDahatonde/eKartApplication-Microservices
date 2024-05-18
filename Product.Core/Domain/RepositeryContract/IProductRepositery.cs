using Product.Core.Domain.Entities;

namespace Product.Core.Domain.RepositeryContract
{
    /// <summary>
    /// IProductRepository impemented Add, Update, Delete, Read fuctionality Products DbSet
    /// </summary>
    public interface IProductRepository : IGenericRepository<Products>
    {
    }
}
