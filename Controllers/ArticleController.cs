using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Service;


namespace WebApp1.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ArticleService _service;
        public ArticleController(ArticleService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            //var articles = await _service.GetAllAsync();
            //return View(articles);

            var articles = await _service.GetApprovedAsync();
            return View(articles);

        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        // GET: ArticleController/Details/5

        public async Task<IActionResult> Details(int id) // 
        {
            var article = await _service.GetByIdAsync(id); //

            if (article == null)
                return NotFound("Статья не найдена");

            return View(article);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArticleController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ArticleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArticleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArticleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArticleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        public IActionResult Buy(int id)
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(string title, string content)
        {
            var email = User.Identity.Name;

            await _service.CreateAsync(title, content, email);

            return RedirectToAction("Index");
        }
    }
}
