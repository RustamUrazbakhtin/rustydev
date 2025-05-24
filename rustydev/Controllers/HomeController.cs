using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rustydev.Data;
using rustydev.Models;

namespace rustydev.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //TODO: Finish the database and integrate it into the project
        //private readonly DbRustyDevContext _context = new DbRustyDevContext();


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var skills = _context.Skills
            //    .Select(s => new SkillList
            //    {
            //        Id = s.Id,
            //        Name = s.Name,
            //        IconPath = s.IconPath
            //    }).ToList();

            //return View(skills);
            return View();

        }

        public IActionResult Projects()
        {
            return View();
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
