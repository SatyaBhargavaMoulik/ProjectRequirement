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
            // If you want to save usr information then calla function from repository and save it in DB  (ID, RoleID, Name)
            return View();
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            List<RoleDetail> lst = objRole.GetAllRoles();
            List<SelectListItem> lstRoles = new List<SelectListItem>();
            if (lst.Count > 0)
            {
                foreach (RoleDetail rr in lst)
                {
                    SelectListItem item = new SelectListItem();
                    item.Text = rr.RoleName;
                    item.Value = rr.RoleID.ToString();
                    lstRoles.Add(item);
                }
            }

            ViewBag.RoleInformation = lstRoles;
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(UserDetailViewModel usr)
        {
            // Pass usr to repository and save into table
            return View();
        }
    }
}
