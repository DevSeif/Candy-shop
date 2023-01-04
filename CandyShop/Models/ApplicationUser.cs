using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CandyShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        //[Key]
        //public int PersonId { get; set; }
        public string Name { get; set; }
        //public List<Candy> Candies { get; set; }
    }
}
