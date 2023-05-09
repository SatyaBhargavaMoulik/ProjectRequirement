using Microsoft.AspNetCore.Mvc;
using MVCCore_StateManagement.Models;

namespace MVCCore_StateManagement.Controllers
{
    public class MyFirstController : Controller
    {
        public IActionResult Index()
        {
            ViewData["MyName"] = "Abhijeet";

            ViewBag.CityID = 201;

            TempData["MyCountry"] = "India";

            HttpContext.Session.SetString("FriendName", "Amit");

            // return View();


            return RedirectToAction("Index", "MySecond");
        }
        [HttpGet]
        public IActionResult SubmitHiddenData()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitHiddenData(MyUserLogin usr, string result)
        {
            return View();
        }
    }
}
