using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CandyShop.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerFName { get; set; } = null!;
        public string CustomerLName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int PostalCode { get; set; }
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public  string Email { get; set; } = null!;
        public string PassWordHash { get; set; }
        public string CreditCardNumber { get; set; }
        public int RoleId { get; set; }
        public Cart Cart { get; set; }
        public int ShoppingCartId { get; set; }

    }
}
