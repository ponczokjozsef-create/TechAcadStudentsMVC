using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Instructor(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        public IActionResult Instructors()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["School"] = "The Tech Academy";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
