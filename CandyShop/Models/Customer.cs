using System.ComponentModel.DataAnnotations;

namespace CandyShop.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerFName { get; set; } = null!;
        public string CustomerLName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public  string Email { get; set; } = null!;


    }
}
