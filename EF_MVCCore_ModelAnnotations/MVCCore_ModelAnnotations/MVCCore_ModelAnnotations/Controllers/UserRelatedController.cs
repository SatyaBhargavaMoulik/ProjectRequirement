using Microsoft.AspNetCore.Mvc;
using MVCCore_ModelAnnotations.Infrastructure;
using MVCCore_ModelAnnotations.Models;

namespace MVCCore_ModelAnnotations.Controllers
{
    public class UserRelatedController : Controller
    {
        IUserInfoRepository _repo = new UserInfoRepository();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserDetail usr)
        {
          

            if(ModelState.IsValid)
            {
                string msg = _repo.SaveUserDetail(usr);
            }
            else
            {
                // Take action of invalid items
                // string s = "Invalid data";
            }


            return View();
        }
    }
}
