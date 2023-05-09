using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCore_Dropdown_Binding.Models;

namespace MVCCore_Dropdown_Binding.Controllers
{
    public class DropdownExampleController : Controller
    {
        RoleDetail objRole = new RoleDetail();
        [HttpGet]
        public IActionResult Index()
        {
            List<RoleDetail> lst =  objRole.GetAllRoles();
            UserDetailViewModel userVW = new UserDetailViewModel();
            userVW.RolesInfo = lst;

            return View(userVW);
        }

        [HttpPost]
        public IActionResult Index(UserDetailViewModel usr)
        {
            // Now we collected "Name" as well as all objects of Role with "Selected" property as TRUE/FALSE
            // If necessary to save info into DB table pass it to repository

            return View();
        }

       
    }
}
