using Microsoft.AspNetCore.Mvc;
using Product.Core.Dto;
using Product.Core.ServicesContract;

namespace Product.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private ResponseDto _responseDto;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _responseDto = new ResponseDto();
        }
        [HttpGet("/Category")]
        public async Task<ResponseDto> GetCategoryProduct(string? name)
        {
            _responseDto.Result = await _categoryService.GetCategoriesProductAsync(name);
            return _responseDto;
        }
    }
}
