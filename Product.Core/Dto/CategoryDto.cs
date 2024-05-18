namespace Product.Core.Dto
{
    public class CategoryDto
    {
        public int? CategoryId { get; set; }
        public string? Name { get; set; }
        public List<ProductDto>? ProductDtos { get; set; }
    }
}
