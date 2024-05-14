using Microsoft.AspNetCore.Mvc;

namespace MVC_CodeFirst.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
