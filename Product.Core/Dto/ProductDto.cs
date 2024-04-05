using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? QuantityAvailable { get; set; }
        public int? CategoryId { get; set; }
        public CategoryDto? Category { get; set; }
        public int? Discount { get; set; }
        public string? ImageUrl { get; set; } = null;
        public decimal? PriceAfterDiscount { get; set; }
    }
}
