using Microsoft.AspNetCore.Mvc;
using MVCCore_Basic_Architecture.Models;

namespace MVCCore_Basic_Architecture.Controllers
{
    public class RazorFormControlsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string uid, string pwd)
        {
            // Coding or action


            return View();
        }

        [HttpGet]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(UserLogin ul)
        {
            // Coding or action


            return View();
        }

        [HttpGet]
        public IActionResult MyLoginPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MyLoginPage(UserLogin ul)
        {
            // Coding or action


            return View();
        }

    }
}
