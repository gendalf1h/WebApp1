using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index() // contacts
        {
            return View();
        }

        [HttpPost] // чтобы метод срабатывал только для получения данных из формы (метод должен принимать данные методом post)
        public IActionResult Check(Contact contact)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/"); // пока что переодресация на главную страницу, а так тут можно подключиться к базе данных и сохрнать данные
            }

            return View("Index"); // если будут ошибки возвращаем шаблон Index

        }

    }
}
