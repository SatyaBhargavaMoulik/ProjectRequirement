using Microsoft.AspNetCore.Mvc;

namespace MVCCore_StateManagement.Controllers
{
    public class MyFirstController : Controller
    {
        public IActionResult Index()
        {
            ViewData["MyName"] = "Abhijeet";

            ViewBag.CityID = 201;

            TempData["MyCountry"] = "India";

            // return View();


            return RedirectToAction("Index", "MySecond");
        }
    }
}
