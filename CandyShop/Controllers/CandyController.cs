using CandyShop.Areas.Identity.Data;
using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CandyShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandyController : ControllerBase
    {
        readonly ApplicationDbContext _context;

        public CandyController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public CandiesAndCategoriesVM GetCandiesAndCategories()
        {
            var vm = new CandiesAndCategoriesVM();
            vm.Candies = _context.Candies.ToList();
            vm.Categories = _context.Categories.ToList();

            return vm;
        }

        [HttpGet("categories")]
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        [HttpGet("users")]
        public List<ApplicationUser> GetUsers()
        {
            return _context.Customers.ToList();
        }
    }
}
