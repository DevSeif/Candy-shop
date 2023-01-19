using CandyShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CandyShop.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet("users")]
        public List<ApplicationUser> GetUsers()
        {
            return _context.Customers.Include(c => c.Cart).Include(i => i.Cart.ItemOrders).ToList();
        }


        [HttpDelete("deleteuser/{id}")]
        public IActionResult DeleteUser(string id)
        {
            ApplicationUser customer = _context.Customers.Find(id);
            if (customer == null) return StatusCode(400);

            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return StatusCode(200);
        }

    }
}
