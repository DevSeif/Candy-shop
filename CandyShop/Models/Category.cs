namespace CandyShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Candy> Candies { get; set; }
    }
}
