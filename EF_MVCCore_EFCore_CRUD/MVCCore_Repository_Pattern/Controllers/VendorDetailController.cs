using Microsoft.AspNetCore.Mvc;
using MVCCore_Repository_Pattern.Models;
using DataAccessRepository.Infrastructure.Repo;
using DataAccessRepository.Infrastructure.Abstract;
using DataAccessRepository.RepoModels;
using DataAccessEFCore.InfraStructureEF.AbstractEF;
using DataAccessEFCore.InfraStructureEF.RepoEF;
using DataAccessEFCore.RepoModelsEF;

namespace MVCCore_Repository_Pattern.Controllers
{
    public class VendorDetailController : Controller
    {
        IVendorInformationRepositoryEF _obj = new VendorInformationRepositoryEF();
        public IActionResult Index()
        {
          List<VendorInformationEF> lst =  _obj.GetAllVendors();

            return View(lst);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VendorInformationEF vndr)
        {
          string msg =  _obj.InsertVendor(vndr);

            if(msg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            VendorInformationEF vndr =  _obj.GetVendorOnVID(Convert.ToInt32(id));

            return View(vndr);
        }

        [HttpPost]
        public IActionResult Edit(VendorInformationEF vndr)
        {
            string msg = _obj.UpdateVendor(vndr);

            if (msg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            VendorInformationEF vndr = _obj.GetVendorOnVID(Convert.ToInt32(id));

            return View(vndr);
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            string msg = _obj.DeleteVendorONVendorID(Convert.ToInt32(id));
            if (msg.Trim().ToLower().Equals("success"))
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
