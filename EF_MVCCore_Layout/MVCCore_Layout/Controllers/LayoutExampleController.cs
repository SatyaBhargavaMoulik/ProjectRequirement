using Microsoft.AspNetCore.Mvc;

namespace MVCCore_Layout.Controllers
{
    public class LayoutExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult MyPPartialView()
        {
            return View();
        }

    }
}
