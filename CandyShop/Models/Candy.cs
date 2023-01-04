using System.ComponentModel.DataAnnotations;

namespace CandyShop.Models
{
    public class Candy
    {
        [Key]
        public int CandyId { get; set; }

        public string CandyName { get; set; } = null!;

        public string CandyDescription { get; set; } = null!;

        public Category CandyCategory { get; set; } = null!;

        public int CandyCategoryId { get; set; }

        public double CandyPrice { get; set; }

        public int CandyQuantity { get; set; }

        //public string Image { get; set; } = null!;

    }
}
