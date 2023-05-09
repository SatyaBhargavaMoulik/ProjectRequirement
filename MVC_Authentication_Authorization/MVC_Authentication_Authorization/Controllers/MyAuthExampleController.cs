using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MVC_Authentication_Authorization.Infrastructure;
using MVC_Authentication_Authorization.Models;
using System.Security.Claims;

namespace MVC_Authentication_Authorization.Controllers
{
    public class MyAuthExampleController : Controller
    {

        IAuthRepository _repo = new AuthRepository();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserDetailViewModel usrVM)
        {
            UserDetail dt = _repo.AuthenticateUser(usrVM);

            if (dt == null)                             // If NULL we will asume that authentication failed
            {
                return RedirectToAction("MyInstruction");
            }
            else
            {
                string[] userRoles = new string[] { dt.RoleDescr };

                var claims = new List<Claim>();
                claims.Add(new Claim("username", dt.UserID));   // u001
                claims.Add(new Claim(ClaimTypes.NameIdentifier, dt.UserID));      // 1111
                foreach (var eachRole in userRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, eachRole));
                }

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("DisplayData", "MySecond");
            }



            return View();
        }

        public IActionResult MyInstruction()
        {
            return View();
        }
    }
}
