using System.ComponentModel.DataAnnotations;

namespace CandyShop.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int CandyId { get; set; }
        public string CandyName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }
    }
}
