using Imdb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Imdb.Controllers
{
    public class MoviesController : Controller
    {

        public MoviesController(ImdbContext context)
        {
            Context = context;
        }

        private ImdbContext Context { get; }

        [Route("/Movies/{UrlSlug}")] // kanske litet u
        public IActionResult Index(string urlSlug)
        {

            var viewModel = Context.Movies
                .Include(X => X.Genre)
                .FirstOrDefault(X => X.UrlSlug == urlSlug);

            return View(viewModel);
        }
    }
}
