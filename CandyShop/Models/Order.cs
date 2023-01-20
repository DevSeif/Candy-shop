namespace CandyShop.Models
{
    public class Order
    {
        public DateTime OrderDate { get; set; }
        public int TotalAmount { get; set; }
        public List<ItemOrder> Items { get; set; }
    }
}
