using System.ComponentModel.DataAnnotations;

namespace Product.Core.Domain.Entities
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? QuantityAvailable { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public int? Discount { get; set; }
        public bool isInStock { get; set; } = true;
        public string? ImageUrl { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
    }
}
