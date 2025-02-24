using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08Group4_7.Models;

namespace Mission08Group4_7.Controllers
{
    public class HomeController : Controller
    {
        private TaskDbContext _taskContext;
        public HomeController(TaskDbContext temp)
        {
            _taskContext = temp;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Quadrants()
        {
            var tasks = _taskContext.Tasks
                .Where(x => x.Completed == false)
                .ToList(); // Load all tasks
            return View(tasks);
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            ViewBag.Categories = _taskContext.Categories.ToList(); // Re-populate dropdown list
            return View();
        }







    }
}
