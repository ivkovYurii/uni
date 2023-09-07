using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Product[]
            {
                new Product("Table", "Furniture", 300m),
                new Product("Chair", "Furniture", 40m),
                new Product("Great new world", "Books", 15m)
            });
        }
    }
}
