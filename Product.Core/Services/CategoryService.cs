using Contracts;
using Product.Core.Domain.RepositeryContract;
using Product.Core.Dto;
using Product.Core.ServicesContract;
namespace Product.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepositery _categoryRepositery;
        private readonly ILoggerManager _logger;
        public CategoryService(ICategoryRepositery categoryRepositery, ILoggerManager logger)
        {
            _categoryRepositery = categoryRepositery;
            _logger = logger;
        }
        public async Task<IEnumerable<CategoryDto>> GetAllCategoryAsync()
        {
            List<CategoryDto> categoryDtoList = new List<CategoryDto>();
            try
            {
                var categoryList = await _categoryRepositery.GetAll();
                foreach (var category in categoryList)
                {
                    categoryDtoList.Add(new CategoryDto()
                    {
                        CategoryId = category.CategoryId,
                        Name = category.Name,
                        ProductDtos = new List<ProductDto>()
                    });
                }

            }
            catch (Exception exception)
            {
                _logger.LogError($"[GetAllCategoryAsync] In CategoryService - {exception.Message}");
                throw;
            }
            return categoryDtoList;
        }

        public async Task<CategoryDto> GetCategoriesProductAsync(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new CategoryDto();
            }
            CategoryDto categoryDtoList = new CategoryDto();
            try
            {
                var categoryList = await _categoryRepositery.GetAsync(x => x.Name.ToLower() == name.ToLower(), "Products");


                categoryDtoList.Name = categoryList.Name;
                categoryDtoList.CategoryId = categoryList.CategoryId;
                categoryDtoList.ProductDtos = new List<ProductDto>();
                if (categoryList.Products != null)
                {
                    foreach (var product in categoryList.Products)
                    {

                        categoryDtoList.ProductDtos.Add(new ProductDto()
                        {
                            Price = product.Price,
                            Description = product.Description,
                            CategoryId = product.CategoryId,
                            Name = product.Name,
                            Discount = product.Discount,
                            isInStock = product.isInStock,
                            ImageUrl = product.ImageUrl,
                            ProductId = product.ProductId,
                            QuantityAvailable = product.QuantityAvailable,
                            CreatedDate = product.InsertedDate,
                            PriceAfterDiscount = CalculatePriceAfterDiscount(product.Price, product.Discount)
                        });
                    }
                }

            }
            catch (Exception exception)
            {
                _logger.LogError($"[GetCategoriesProductAsync] In CategoryService - {exception.Message}");
            }

            return categoryDtoList;
        }
        public decimal? CalculatePriceAfterDiscount(decimal? price, decimal? discount)
        {
            if (price != null && discount > 0)
                return price * (1 - (discount / 100));
            else return null;
        }
    }
}
