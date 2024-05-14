using Microsoft.AspNetCore.Mvc;
using MVC_CodeFirst.Areas.Dashboard.Models.Abstracts;
using MVC_CodeFirst.Areas.Dashboard.Models.Entities;
using MVC_CodeFirst.Models.Context;
using MVC_CodeFirst.Models.Entities;
using Genre = MVC_CodeFirst.Areas.Dashboard.Models.Entities.Genre;

namespace MVC_CodeFirst.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class GenreController : Controller
    {
        private readonly IGenreRepository _genreRepository;

        public GenreController(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                _genreRepository.AddGenre(genre);
                return RedirectToAction("Index");
            }
            return View(genre);
            
        }
    }
    
}
