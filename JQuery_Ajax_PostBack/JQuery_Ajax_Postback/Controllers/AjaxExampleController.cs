using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JQuery_Ajax_Postback.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JQuery_Ajax_Postback.Controllers
{
    public class AjaxExampleController : Controller
    {
        Country _objCountry = new Country();
        public ActionResult LoadCountries()
        {
            List<Country> lstCountry = _objCountry.GetCountries();

            // Since dropdown will support a generic collection of "SelectListItem" class type so convert to that type to bind
            List<SelectListItem> countryList = new List<SelectListItem>();
            foreach (Country eachCountry in lstCountry)
            {
                SelectListItem obj = new SelectListItem();
                obj.Text = eachCountry.CountryName;
                obj.Value = eachCountry.CountryId.ToString();
                countryList.Add(obj);
            }

            ViewData["countryList"] = countryList;

            return View();
        }


        [HttpPost]
        public JsonResult GetStates(string id)
        {
            List<SelectListItem> lstStates = _objCountry.GetStates(id);

            return Json(lstStates);

        }
    }
}
