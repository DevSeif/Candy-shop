using CandyShop.Areas.Identity.Data;
using CandyShop.Models;
using CandyShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System;
using Microsoft.AspNetCore.Identity;
using CandyShop.Migrations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace CandyShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;

        public CandyController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IUserStore<ApplicationUser> userStore)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser();

                user.CustomerFName = model.CustomerFName;
                user.CustomerLName = model.CustomerLName;
                user.PostalCode = model.PostalCode;
                user.PhoneNumber = model.PhoneNumber;
                user.Address = model.Address;
                user.City = model.City;
                user.Country = model.Country;
                user.CreditCardNumber = model.CreditCardNumber;


                await _userStore.SetUserNameAsync(user, model.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, model.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                    Cart cart = new Cart { CustomerCartId = user.Id, TotalPrice = 0 };
                    _context.Carts.Add(cart);
                    _context.SaveChanges();
                    _signInManager.SignInAsync(user, isPersistent: false);
                    return StatusCode(200);
                }
            }

            return StatusCode(400);
        }


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

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return LocalRedirect("/");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginVM model)
        {

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);

            if (result.Succeeded)
            {

                return StatusCode(200);
            }
            return StatusCode(400);
        }

        [HttpGet("getusername")]
        public string GetUsername()
        {
            var username = _userManager.GetUserName(User);
            if(username == null || username == "") { return "null"; }
            return username;
        }

        [HttpGet("getroles")]
        public async Task<List<string>> GetRoles()
        {
            var user = await _userManager.GetUserAsync(User);
            var roles = await _userManager.GetRolesAsync(user);

            return roles.ToList();
        }

        [HttpGet("getid")]
        public async Task<string> GetId()
        {
            var user = await _userManager.GetUserAsync(User);
        

            return user.Id;
        }


        private IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            return (IUserEmailStore<ApplicationUser>)_userStore;
        }
    }
}
