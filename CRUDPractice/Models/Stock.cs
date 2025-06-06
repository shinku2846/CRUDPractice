using System.ComponentModel.DataAnnotations;

namespace CRUDPractice.Models
{
    public class Stock
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        [Range(0, 100000)]
        public decimal Count { get; set; }

        public string StorePosition { get; set; }
    }
}

