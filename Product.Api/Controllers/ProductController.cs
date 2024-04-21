using Microsoft.AspNetCore.Mvc;
using Product.Core.Dto;
using Product.Core.ServicesContract;

namespace Product.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productServices;
        private ILogger<ProductController> _logger;
    
        private ResponseDto _responseDto;
        public ProductController(IProductService productServices, ILogger<ProductController> logger)
        {
            _productServices = productServices;
            _logger = logger;
            _responseDto = new ResponseDto();
        }
        [HttpGet("GetAll/Product")]
        public async Task<ResponseDto> GetAll()
        {
            try
            {
                _responseDto.Result = await _productServices.GetAllProductAsync();
                _logger.LogInformation("GetAll - Called successfully From Controller");
            }
            catch(Exception ex)
            {
                _responseDto.Message= ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }
        [HttpGet("GetAllProductByConditionAsync")]
        public async Task<ResponseDto> GetAllProductByConditionAsync([FromQuery] string? condition, [FromQuery] string? value)
        {
            try
            {
                _responseDto.Result = await _productServices.GetAllProductByConditionAsync(condition,value);
                _logger.LogInformation("GetAllProductByConditionAsync - Called successfully From Controller");
            }
            catch (Exception ex)
            {
                _responseDto.Message = ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }
        [HttpGet("GetById/{id}")]
        public async Task<ResponseDto> GetById(int? Id)
        {
            try
            {
                _responseDto.Result = await _productServices.GetProductByIdAsync(Id);
                _logger.LogInformation("GetById - Called successfully From Controller");
            }
            catch (Exception ex)
            {
                _responseDto.Message = ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }
        [HttpPost("AddProduct")]
        public async Task<ResponseDto>Post(ProductDto? productDto)
        {
            try
            {
                _responseDto.Result =await _productServices.AddProductAsync(productDto);
                _logger.LogInformation("AddProduct- Called successfully From Controller");
            }
            catch (Exception ex)
            {
                _responseDto.Message = ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }
        [HttpPut("UpdateProduct")]
        public async Task<ResponseDto> Put(ProductDto? productDto)
        {
            try
            {
                _responseDto.Result = await _productServices.UpdateProductAsync(productDto);
                _logger.LogInformation("UpdateProduct - Called successfully From Controller");
            }
            catch (Exception ex)
            {
                _responseDto.Message = ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }

        [HttpDelete("DeleteProduct")]
        public async Task<ResponseDto> Delete(int? Id)
        {
            try
            {
                _responseDto.Result = await _productServices.DeleteProductAsync(Id);
                _logger.LogInformation("Delete-Called successfully From Controller");
            }
            catch (Exception ex)
            {
                _responseDto.Message = ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }
    }
}
