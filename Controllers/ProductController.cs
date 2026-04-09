using Microsoft.AspNetCore.Mvc;
using WebApp1.Service;
using WebApp1.Models;
namespace WebApp1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _service;
        public ProductController (ProductService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index() // страница со всеми курсами 
        {
            var products = await _service.GetAllAsync();
            var vm = products.Select(c => new ProductCardVm
            {
                Id = c.Id,
                Title = c.Title,
                ImageUrl = c.ImageUrl
            }).ToList();


            return View(vm);
        }

        public async Task<IActionResult> Details(int id) // страница одного курса
        {
            var product = await _service.GetByIdAsync(id);

            if(product == null)
            {
                return NotFound();
            }

            var vm = new ProductDetailsVm
            {
                Title = product.Title,
                ImageUrl = product.ImageUrl,
                Description = product.Description,
                Price = product.Price,
            };

            return View(vm);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
