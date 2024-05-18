using Product.Core.Dto;

namespace Product.Core.ServicesContract
{
    public interface IProductService
    {
        Task<ProductDto> AddProductAsync(ProductDto? productDto);
        Task<ProductDto> DeleteProductAsync(int? id);
        Task<ProductDto> UpdateProductAsync(ProductDto? productDto);
        Task<IEnumerable<ProductDto>> GetAllProductAsync();
        Task<ProductDto> GetProductByIdAsync(int? Id);
        Task<IEnumerable<ProductDto>> GetAllProductByConditionAsync(string? condition, string? value);
    }
}
