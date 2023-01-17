using CandyShop.Areas.Identity.Data;
using CandyShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public List<Candy> GetCandies()
        {
            return _context.Candies.ToList();
        }

        [HttpGet("categories")]
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
