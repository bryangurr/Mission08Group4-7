using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08Group4_7.Models;

namespace Mission08Group4_7.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }


    }
}
