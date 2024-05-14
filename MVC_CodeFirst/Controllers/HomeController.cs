using Microsoft.AspNetCore.Mvc;

namespace MVC_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
