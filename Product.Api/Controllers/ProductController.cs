using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Product.Core.Dto;
using Product.Core.Services;
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
        [HttpGet("Get/Product")]
        public async Task<ResponseDto> GetAll()
        {
            try
            {
                _responseDto.Result = await _productServices.GetAllProductAsync();
                _logger.LogInformation($"[GetAll] - Called successfully");
            }
            catch(Exception ex)
            {
                _responseDto.Message= ex.Message;
                _responseDto.Status = false;
            }
            return _responseDto;
        }
    }
}
