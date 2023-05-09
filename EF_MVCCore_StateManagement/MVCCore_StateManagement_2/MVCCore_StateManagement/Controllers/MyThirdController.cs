using Microsoft.AspNetCore.Mvc;

namespace MVCCore_StateManagement.Controllers
{
    public class MyThirdController : Controller
    {
        public IActionResult Index()
        {
            //if (TempData["MyCountry"] != null)
            //{
            //    ViewBag.CollectedCountry = TempData["MyCountry"].ToString();

            //}


            string fName = HttpContext.Session.GetString("FriendName");

            if (!string.IsNullOrEmpty(fName))
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
