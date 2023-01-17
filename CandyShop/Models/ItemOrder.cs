using System.ComponentModel.DataAnnotations;

namespace CandyShop.Models
{
    public class ItemOrder
    {
        [Key]
        public int ItemOrderId { get; set; }
        public int CandyId { get; set; }
        public string CandyName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
