using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_With_BSTemplate.Controllers
{
    public class LoginPageController : Controller
    {
        [HttpGet]
        public IActionResult Login_Page()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login_Page(string uid, string pwd)
        {

            return View();
        }
    }
}
