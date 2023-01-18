using CandyShop.Areas.Identity.Data;
using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System;

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


        //[HttpGet]
        //public CandiesAndCategoriesVM GetCandiesAndCategories()
        //{
        //    var vm = new CandiesAndCategoriesVM();

        //    vm.Candies = _context.Candies.ToList();
        //    vm.Categories =null;

        //    return vm;
        //}

        [HttpGet("candies")]
        public List<Candy> GetCandies()
        {
            return _context.Candies.ToList();
        }

        [HttpGet("categories")]
        public List<Category> GetCategories()
        {
            return _context.Categories.Include(x => x.Candies).ToList();
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


        [HttpPost("add")]
        public IActionResult AddToCart(JsonObject item)
        {
            string jsonItem = item.ToString();

            ItemOrder itemObject = JsonConvert.DeserializeObject<ItemOrder>(jsonItem);

            if (itemObject != null)
            {
                _context.ItemOrders.Add(itemObject);
                _context.SaveChanges();

                return StatusCode(200);
            }
            return StatusCode(400);


        }
    }
}
