using Microsoft.Extensions.Logging;
using Product.Core.Domain.Entities;
using Product.Core.Domain.RepositeryContract;
using Product.Core.Dto;
using Product.Core.Helper;
using Product.Core.ServicesContract;

namespace Product.Core.Services
{
    public class ProductServices : IProductService
    {
        private readonly IProductRepository _productRepository;
        private ILogger<ProductServices> _logger;

        /// <summary>
        /// Initializes a new instance 
        /// </summary>
        /// <param name="IProductRepository">dfhgdj</param>
        /// <param name="ILogger<ProductService>">gfhk</param>
        public ProductServices(IProductRepository productRepository, ILogger<ProductServices> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        /// <inheritdoc/>
        public async Task<ProductDto> AddProductAsync(ProductDto? productDto)
        {
            if (productDto == null)
            {
                throw new ArgumentNullException(nameof(productDto));
            }

            ValidationHelper.ModelValiation(productDto);

            try
            {
                // Map ProductDto to Products entity
                var product = new Products()
                {
                    Name = productDto.Name,
                    Description = productDto.Description,
                    Discount = productDto.Discount,
                    CategoryId = productDto.CategoryId,
                    ImageUrl = $"https://via.placeholder.com/600x500.png?text={productDto.Name}",
                    Price = productDto.Price,
                    QuantityAvailable = productDto.QuantityAvailable,
                };

                if (productDto.Category != null && productDto.Category.CategoryId!=0&&productDto.Category.Name!="")
                {
                    product.Category = new Category()
                    {
                        CategoryId = productDto.Category.CategoryId,
                        Name = productDto.Category.Name
                    };
                }

                await _productRepository.AddAsync(product);
                var result = await _productRepository.CompleteAsync();

                if (result != 0)
                {
                    return productDto;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"[AddProductAsync] - {ex.Message}");
            }

            return new ProductDto();
        }


        /// <inheritdoc/>
        public async Task<ProductDto> UpdateProductAsync(ProductDto? productDto)
        {
            if (productDto == null)
            {
                throw new ArgumentNullException(nameof(productDto));
            }

            ValidationHelper.ModelValiation(productDto);

            try
            {
                // Map ProductDto to Products entity
                var product = new Products()
                {
                    ProductId = productDto.ProductId,
                    Name = productDto.Name,
                    Description = productDto.Description,
                    Discount = productDto.Discount,
                    CategoryId = productDto.CategoryId,
                    ImageUrl = productDto.ImageUrl,
                    Price = productDto.Price,
                    QuantityAvailable = productDto.QuantityAvailable,
                };

                if (productDto.Category != null && productDto.Category.CategoryId != 0 && productDto.Category.Name != "")
                {
                    product.Category = new Category()
                    {
                        CategoryId = productDto.Category.CategoryId,
                        Name = productDto.Category.Name
                    };
                }

                await _productRepository.UpdateAsync(product);
                var result = await _productRepository.CompleteAsync();

                if (result != 0)
                {
                    return productDto;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"[UpdateProductAsync] - {ex.Message}");
            }

            return new ProductDto();
        }


        /// <inheritdoc/>
        public async Task<ProductDto?> GetProductByIdAsync(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            try
            {
                var product = await _productRepository.GetAsync(x => x.ProductId == id, "Category");

                if (product == null)
                {
                    return null;
                }

                var productDto = new ProductDto()
                {
                    Name = product.Name,
                    ProductId = product.ProductId,
                    Description = product.Description,
                    CategoryId = product.CategoryId,
                    Discount = product.Discount,
                    ImageUrl = product.ImageUrl,
                    CreatedDate=product.InsertedDate,
                    QuantityAvailable = product.QuantityAvailable,
                    Price = product.Price,
                    PriceAfterDiscount = CalculatePriceAfterDiscount(product.Price, product.Discount)
                };

                if (product.Category != null)
                {
                    productDto.Category = new CategoryDto()
                    {
                        CategoryId = product.Category.CategoryId ?? null,
                        Name = product.Category.Name ?? null
                    };
                }

                return productDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"[GetProductByIdAsync] - {ex.Message}");
                return null;
            }
        }

        public  decimal? CalculatePriceAfterDiscount(decimal? price, decimal?discount)
        {
            if(price!=null&&discount>0) 
            return price * (1 - (discount / 100));
            else return null;
        }
        /// <inheritdoc/>
        public async Task<IEnumerable<ProductDto>> GetAllProductAsync()
        {
            try
            {
                var responseProduct = await _productRepository.GetAll("Category");

                List<ProductDto> productList = new List<ProductDto>();

                if (responseProduct != null)
                {
                    foreach (var product in responseProduct)
                    {
                        var productDto = new ProductDto()
                        {
                            Name = product.Name,
                            ProductId = product.ProductId,
                            Description = product.Description,
                            CategoryId = product.CategoryId,
                            Discount = product.Discount,
                            CreatedDate = product.InsertedDate,
                            ImageUrl = product.ImageUrl,
                            Price = product.Price,
                            QuantityAvailable = product.QuantityAvailable,
                            PriceAfterDiscount = product.Price * (1 - (product.Discount / 100))
                        };

                        if (product.Category != null)
                        {
                            productDto.Category = new CategoryDto()
                            {
                                CategoryId = product.Category.CategoryId,
                                Name = product.Category.Name
                            };
                        }

                        productList.Add(productDto);
                    }

                    return productList;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"[GetAllProductAsync] - {ex.Message}");
            }

            return Enumerable.Empty<ProductDto>();
        }


        /// <inheritdoc/>
        public async Task<ProductDto> DeleteProductAsync(int? productId)
        {
            if (productId == null)
            {
                throw new ArgumentNullException(nameof(productId));
            }

            try
            {
                var existingProduct = await _productRepository.FirstOrDefaultAsync(x => x.ProductId == productId);
                if (existingProduct == null)
                {
                    throw new ArgumentException($"Product with ID {productId} not found.");
                }

                var deletedProduct = await _productRepository.DeleteAsync(x => x.ProductId == productId);
                await _productRepository.CompleteAsync();

                var productDto = new ProductDto()
                {
                    Name = deletedProduct.Name,
                    Discount = deletedProduct.Discount,
                    ImageUrl = deletedProduct.ImageUrl,
                    Price = deletedProduct.Price,
                    Description = deletedProduct.Description,
                };

                if (deletedProduct.Category != null)
                {
                    productDto.CategoryId = deletedProduct.Category.CategoryId;
                    productDto.Category = new CategoryDto()
                    {
                        Name = deletedProduct.Category.Name,
                        CategoryId = deletedProduct.Category.CategoryId,
                    };
                }

                return productDto;

            }
            catch (Exception ex)
            {
                _logger.LogError($"[DeleteProductAsync] - {ex.Message}");
                throw;
            }
        }
        /// <summary>
        /// Get All Product Base On user Specify Condition and return List of Product
        /// </summary>
        /// <param name="condition">condition on which user want to filter like name,price etc</param>
        /// <param name="value">value user want to find out</param>
        /// <returns></returns>
        public async Task<IEnumerable<ProductDto>> GetAllProductByConditionAsync(string? condition, string? value)
        {
            if (string.IsNullOrEmpty(condition) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(condition), nameof(value));
            }

            try
            {
                var productsEnumerable = await GetAllProductAsync();
                IQueryable<ProductDto> query = productsEnumerable.AsQueryable();
                switch (condition.ToLower())
                {
                    case "name":
                        query = query.Where(p => p.Name.ToLower().Contains(value.ToLower(),StringComparison.OrdinalIgnoreCase));
                        break;
                    default:
                        query = query.Where(p => p.Name == value);
                        break;
                }
                return query.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[GetAllProductByConditionAsync] - {ex.Message}");
                return Enumerable.Empty<ProductDto>();
            }
        }
    }
}
