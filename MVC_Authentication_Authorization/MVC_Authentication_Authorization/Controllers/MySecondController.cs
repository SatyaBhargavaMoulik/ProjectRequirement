using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Authentication_Authorization.Controllers
{


    [Authorize]
    public class MySecondController : Controller
    {
        //[Authorize(Roles = "Admin,Supervisor")]
        public IActionResult Index()
        {
            return View();
        }

        //[Authorize(Roles = "Admin")]
        public IActionResult DeleteData()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult DisplayData()
        {
            return View();
        }
    }
}
