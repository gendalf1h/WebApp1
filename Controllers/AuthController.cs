using Microsoft.AspNetCore.Mvc;
using WebApp1.Service;

namespace WebApp1.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _service;

        public AuthController(AuthService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(string email, string password)
        {
            var succes = await _service.Register(email, password);

            if(!succes)
            {
                ViewBag.Error = "Пользователь уже существует";
                return View();
            }

            return RedirectToAction("Index", "Home");


        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
