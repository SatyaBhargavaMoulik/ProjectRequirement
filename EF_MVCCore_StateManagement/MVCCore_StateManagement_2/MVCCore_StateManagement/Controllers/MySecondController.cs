using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace MVCCore_StateManagement.Controllers
{
    public class MySecondController : Controller
    {
        public IActionResult Index()
        {
            //if (TempData["MyCountry"] != null)
            //{
            //    ViewBag.CollectedCountry = TempData["MyCountry"].ToString();

            //}

            string fName = HttpContext.Session.GetString("FriendName");

            if(!string.IsNullOrEmpty(fName))
            {
                ViewBag.MyFriendName = fName;
            }
            else
            {
                ViewBag.MyFriendName = "Friend name is blank";
            }

            return View();
        }
    }
}
