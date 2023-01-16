using CandyShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Http.Features;

namespace CandyShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public ApplicationUser Customer { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
        }
    }
    public class OrderItem
    {
        public int CandyId { get; set; }
        public string CandyName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

}
