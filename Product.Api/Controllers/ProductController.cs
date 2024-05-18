using Contracts;
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
        private readonly ICategoryService _categoryServices;
        private readonly ILoggerManager _logger;

        private ResponseDto _responseDto;
        public ProductController(IProductService productServices, ILoggerManager logger, ICategoryService categoryServices)
        {
            _productServices = productServices;
            _logger = logger;
            _responseDto = new ResponseDto();
            _categoryServices = categoryServices;
        }
        [HttpGet("GetAll/Product")]
        public async Task<ResponseDto> GetAll()
        {
            try
            {
                _responseDto.Result = await _productServices.GetAllProductAsync();
                _logger.LogInfo("GetAll - Called successfully From Controller");
            }
            catch (Exception ex)
            {
                _responseDto.Message = ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }


        [HttpGet("GetAllProductByConditionAsync")]
        public async Task<ResponseDto> GetAllProductByConditionAsync([FromQuery] string? condition, [FromQuery] string? value)
        {
            try
            {
                _responseDto.Result = await _productServices.GetAllProductByConditionAsync(condition, value);
                _logger.LogInfo("GetAllProductByConditionAsync - Called successfully From Controller");
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
                _logger.LogInfo("GetById - Called successfully From Controller");
            }
            catch (Exception ex)
            {
                _responseDto.Message = ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }
        [HttpPost("AddProduct")]
        public async Task<ResponseDto> Post(ProductDto? productDto)
        {
            try
            {
                _responseDto.Result = await _productServices.AddProductAsync(productDto);
                _logger.LogInfo("AddProduct- Called successfully From Controller");
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
                _logger.LogInfo("UpdateProduct - Called successfully From Controller");
            }
            catch (Exception ex)
            {
                _responseDto.Message = ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }

        [HttpDelete("DeleteProduct/{Id}")]
        public async Task<ResponseDto> Delete(int? Id)
        {
            try
            {
                _responseDto.Result = await _productServices.DeleteProductAsync(Id);
                _logger.LogInfo("Delete-Called successfully From Controller");
            }
            catch (Exception ex)
            {
                _responseDto.Message = ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }
        [HttpGet("GetAll/Category")]
        public async Task<ResponseDto> GetAllCategory()
        {
            try
            {
                _responseDto.Result = await _categoryServices.GetAllCategoryAsync();
                _logger.LogInfo("GetAllCategory - Called successfully From Controller");
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
