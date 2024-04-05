using Microsoft.EntityFrameworkCore;
using Product.Core.Domain.Entities;
using Product.Core.Domain.RepositeryContract;
using Product.Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure.Repositery
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(AppDbContext Context) : base(Context)
        {
        }

    }
}
