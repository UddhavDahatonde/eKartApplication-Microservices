using Product.Core.Dto;

namespace Product.Core.ServicesContract
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoryAsync();
        Task<CategoryDto> GetCategoriesProductAsync(string? name);
    }
}
