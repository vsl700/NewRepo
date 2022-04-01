using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recepti_12b_ASP.Data;
using Recepti_12b_ASP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Recepti_12b_ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Recipes);
        }

        public IActionResult Recipe(int? id)
        {
            return View(_db.Recipes.Find(id));
        }

        public IActionResult SecretPage()
        {
            Recipe recipe = new Recipe();
            return View(recipe);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult SecretPage(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                _db.Add(recipe);
                _db.SaveChanges();
            }

            return View(recipe);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
