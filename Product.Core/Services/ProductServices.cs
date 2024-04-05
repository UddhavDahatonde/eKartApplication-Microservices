using Microsoft.Extensions.Logging;
using Product.Core.Domain.Entities;
using Product.Core.Domain.RepositeryContract;
using Product.Core.Dto;
using Product.Core.ServicesContract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            var product = new Products()
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Discount = productDto.Discount,
                CategoryId = productDto.CategoryId,
                Category = new Category()
                {
                    CategoryId = productDto.Category.CategoryId,
                    Name = productDto.Category.Name
                },
                ImageUrl = productDto.ImageUrl,
                Price = productDto.Price,
                QuantityAvailable = productDto.QuantityAvailable,
            };
            await _productRepository.AddAsync(product);
            var result = await _productRepository.CompleteAsync();
            _logger.LogInformation($"[AddProductAsyns] - {productDto.Name} added successfully");
            if (result != 0)
                return productDto;
            else
                return new ProductDto();
        }

        /// <inheritdoc/>
        public async Task<ProductDto> UpdateProductAsync(ProductDto? productDto)
        {
            var product = new Products()
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Discount = productDto.Discount,
                CategoryId = productDto.CategoryId,
                Category = new Category()
                {
                    CategoryId = productDto.Category.CategoryId,
                    Name = productDto.Category.Name
                },
                ImageUrl = productDto.ImageUrl,
                Price = productDto.Price,
                QuantityAvailable = productDto.QuantityAvailable,
            };
            await _productRepository.UpdateAsync(product);
            var result = await _productRepository.CompleteAsync();
            _logger.LogInformation($"[UpdateProductAsyns] - Product updated successfully for the {productDto.Name}");
            if (result != 0)
                return productDto;
            else
                return new ProductDto();
        }

        /// <inheritdoc/>
        public async Task<ProductDto?> GetProductByIdAsync(int? id)
        {
            var product = await _productRepository.
            FirstOrDefaultAsync(x => x.ProductId == id);
            if (product == null)
            {
                return new ProductDto();
            }
            _logger.LogInformation($"[GetProductByIdAsync] - Called successfully");
            return new ProductDto()
            {
                Name = product.Name,
                ProductId = product.ProductId,
                Description = product.Description,
                CategoryId = product.CategoryId,
                Discount = product.Discount,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                Category = new CategoryDto()
                {
                    CategoryId = product.Category.CategoryId,
                    Name = product.Category.Name
                },
                QuantityAvailable = product.QuantityAvailable,
                PriceAfterDiscount = product.Price - (product.Price * product.Discount)
            };
            
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<ProductDto>> GetAllProductAsync()
        {
            var responseProduct=await _productRepository.GetAll("Category");
            _logger.LogInformation($"[GetProductByIdAsync] - Called successfully");
            List<ProductDto> productList = new List<ProductDto>();
            if (responseProduct != null)
            {
                foreach (var product in responseProduct)
                {
                    productList.Add(new ProductDto()
                    {
                        Name = product.Name,
                        ProductId = product.ProductId,
                        Description = product.Description,
                        CategoryId = product.CategoryId,
                        Discount = product.Discount,
                        ImageUrl = product.ImageUrl,
                        Price = product.Price,
                        Category = new CategoryDto()
                        {
                            CategoryId = product.Category.CategoryId,
                            Name = product.Category.Name
                        },
                        QuantityAvailable = product.QuantityAvailable,
                        PriceAfterDiscount = product.Price - (product.Price * product.Discount)
                    });
                }
                return productList;
            }
            else { return new List<ProductDto>(); }
        }

        /// <inheritdoc/>
        public async Task<ProductDto> DeleteProductAsync(int? productId)
        {
            var product = await _productRepository.DeleteAsync(x => x.ProductId == productId);
            var response = await _productRepository.CompleteAsync();
            _logger.LogInformation($"[DeleteProductAsyns] - Product deleted successfully for the {productId}");
            if (response != 0)
            {
                return new ProductDto()
                {
                    Name = product.Name,
                    Category = new CategoryDto()
                    {
                        Name = product.Category.Name,
                        CategoryId = product.Category.CategoryId
                    },
                    CategoryId = product.Category.CategoryId,
                    Discount = product.Discount,
                    ImageUrl = product.ImageUrl,
                    Price = product.Price,
                    Description = product.Description
                };
            }
            else
                return new ProductDto();
        }

        public Task<IEnumerable<ProductDto>> GetAllProductByConditionAsync(Expression<Func<ProductDto, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
