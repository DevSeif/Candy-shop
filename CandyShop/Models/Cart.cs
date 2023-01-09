namespace CandyShop.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public double TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
       //public int CandyId { get; set; }
        //public Candy Candy { get; set; }
        public List<Candy> Candies { get; set; } = new();
    }
}
