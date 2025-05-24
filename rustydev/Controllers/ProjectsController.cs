using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using rustydev.Models;

namespace rustydev.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ProjectsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var projects = _context.Projects.ToList();
            //return View(projects);
            return View();
        }

        //public IActionResult Details(int id)
        //{
        //    var project = _context.Projects.FirstOrDefault(p => p.Id == id);
        //    if (project == null) return NotFound();
        //    return PartialView("_ProjectDetailsPartial", project);
        //}
    }
}
