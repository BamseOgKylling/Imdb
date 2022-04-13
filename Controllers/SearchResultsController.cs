using Imdb.Data;
using Microsoft.AspNetCore.Mvc;

namespace Imdb.Controllers
{
    public class SearchResultsController : Controller
    {
        public SearchResultsController(ImdbContext context)
        {
            Context = context;
        }

        private ImdbContext Context { get; }

        [Route("/Search")]
        public IActionResult Index([FromQuery] string q)
        {
            var viewModel = Context.Movies
                .Where(x => x.Title.Contains(q))
                .ToList();

            ViewData["SearchString"] = q;

            return View(viewModel);
        }
    }
}

