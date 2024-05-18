using System.ComponentModel.DataAnnotations;

namespace Product.Core.Domain.Entities
{
    public class Category
    {
        public int? CategoryId { get; set; }
        [StringLength(100)]
        [Required]
        public string? Name { get; set; }
        public List<Products>? Products { get; set; }
    }
}
