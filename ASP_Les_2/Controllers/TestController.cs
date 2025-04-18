using ASP_Les_2.Models;
using Microsoft.AspNetCore.Mvc;
namespace ASP_Les_2.Controllers
{ 

    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserInfo()
        {
            var user = new User { Name = "Иван Иванов", Age = 30 };
            return View(user);
        }

        public IActionResult Greet(string name)
        {
            return Content($"Привет, {name}!");
        }
    }
}
