using Imdb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Imdb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MoviesController : Controller
    {

        public MoviesController(ImdbContext context)
        {
            Context = context;
        }

        private ImdbContext Context { get; }




        public IActionResult Index()
        {
            var viewModel = Context.Movies
                .Include(x => x.Genre)
                .ToList();


            return View(viewModel);
        }
    }
}
