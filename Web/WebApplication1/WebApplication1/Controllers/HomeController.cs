using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IDataRepository _repository;

        public HomeController(IDataRepository repository)
        {
            _repository = repository;
        }
        
        public ViewResult Index()// Maybe need to change return type on IActionResult
        {
            return View(_repository.GetAllProducts());
        }

        public IActionResult Create()
        {
            ViewBag.CreateMode = "Create";
            // return View("Editor", new Product());// This line must be uncomment in the future
            
            return View("Editor");
            // This line should be deleted in the future,
            // only for testing that all worked correctly
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _repository.CreateProduct(product);
            return RedirectToAction(nameof(Index));
        }
        
    }
}
