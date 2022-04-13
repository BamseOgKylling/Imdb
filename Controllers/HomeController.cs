using Imdb.Data;
using Imdb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Imdb.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ImdbContext context)
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