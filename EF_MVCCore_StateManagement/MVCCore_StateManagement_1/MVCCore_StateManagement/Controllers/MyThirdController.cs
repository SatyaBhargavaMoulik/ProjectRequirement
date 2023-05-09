using Microsoft.AspNetCore.Mvc;

namespace MVCCore_StateManagement.Controllers
{
    public class MyThirdController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["MyCountry"] != null)
            {
                ViewBag.CollectedCountry = TempData["MyCountry"].ToString();

            }

            return View();
        }
    }
}
