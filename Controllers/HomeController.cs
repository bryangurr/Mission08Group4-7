using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08Group4_7.Models;

namespace Mission08Group4_7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AddTask()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Confirmation(string Task, string DueDate, string Quadrant, string Category, string Completed)
        {
            ViewBag.Task = Task;
            ViewBag.DueDate = DueDate;
            ViewBag.Quadrant = Quadrant;
            ViewBag.Category = Category;
            ViewBag.Completed = Completed;

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
