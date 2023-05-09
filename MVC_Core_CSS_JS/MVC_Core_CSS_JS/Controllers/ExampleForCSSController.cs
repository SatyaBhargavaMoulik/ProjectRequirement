using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_CSS_JS.Controllers
{
    public class ExampleForCSSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MySecondPage()
        {
            return View();
        }
    }
}
