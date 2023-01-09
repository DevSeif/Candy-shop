using Microsoft.Build.Framework;

namespace CandyShop.ViewModels
{
    public class AddCandyViewModel
    {
        [Required]
        public string CandyName { get; set; }

        [Required]
        public decimal CandyPrice { get; set; }
        public string CandyDescription { get; set; }
        [Required]
        public int CandyQuantity { get; set; }
       public List<int> CategoryId { get; set; }
    }
}
