using Microsoft.AspNetCore.Mvc;
using MVCCore_JS.Models;

namespace MVCCore_JS.Controllers
{
    public class MyUsersInfoController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserDetail usr)
        {
            // coding

            return View();
        }
    }
}
