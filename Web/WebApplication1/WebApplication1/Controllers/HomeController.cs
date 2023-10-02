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
        
        public ViewResult Index(string category = null ,decimal? price = null )// Maybe need to change return type on IActionResult
        {
            var data = _repository.GetFilteredProducts(category, price);
            ViewBag.category = category;
            ViewBag.price = price;
            
            // return View(_repository.GetAllProducts());
            return View(data);
        }

        public IActionResult Create()
        {
            ViewBag.CreateMode = true;
            return View("Editor", new Product());// This line must be uncomment in the future
            
            // return View("Editor");
            // This line should be deleted in the future,
            // only for testing that all worked correctly
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _repository.CreateProduct(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            ViewBag.CreateMode = false;
            //return View("Editor", new Product());// This line must be uncomment in the future

            return View("Editor", _repository.GetProduct(id));
            // This line should be deleted in the future,
            // only for testing that all worked correctly
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _repository.UpdateProduct(product);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _repository.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
