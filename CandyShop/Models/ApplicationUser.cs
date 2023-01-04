using Microsoft.AspNetCore.Identity;

namespace CandyShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public string FirstName { get; set; } = null!;
        //public string LastName { get; set; } = null!;
        public Customer Customer { get; set; }
    }
}
