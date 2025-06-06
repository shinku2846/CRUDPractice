using System.ComponentModel.DataAnnotations;

namespace CRUDPractice.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, 100000)]
        public decimal Price { get; set; }

        public List<Stock>? Stocks { get; set; }

        public string? Description { get; set; }
    }
}
