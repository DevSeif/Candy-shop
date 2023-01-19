using Microsoft.AspNetCore.Mvc;

namespace CandyShop.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
