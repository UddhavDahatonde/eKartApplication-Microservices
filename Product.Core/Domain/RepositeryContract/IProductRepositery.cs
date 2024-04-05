using Product.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Domain.RepositeryContract
{
    /// <summary>
    /// IProductRepository impemented Add, Update, Delete, Read fuctionality Products DbSet
    /// </summary>
    public interface IProductRepository : IGenericRepository<Products>
    {
    }
}
