using CandyShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Http.Features;

namespace CandyShop.Models
{
    public class Order
    {
        
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }
        public List<ItemOrder> Items { get; set; }

      
    }
  

}
