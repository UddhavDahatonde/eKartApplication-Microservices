using Product.Core.Domain.Entities;
using Product.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.ServicesContract
{
    public interface IProductService
    {
        Task<ProductDto> AddProductAsync(ProductDto? productDto);
        Task<ProductDto> DeleteProductAsync(int? id);
        Task<ProductDto> UpdateProductAsync(ProductDto? productDto);
        Task<IEnumerable<ProductDto>> GetAllProductAsync();
        Task<ProductDto> GetProductByIdAsync(int? Id);
        Task<IEnumerable<ProductDto>> GetAllProductByConditionAsync(string?condition,string? value);
    }
}
