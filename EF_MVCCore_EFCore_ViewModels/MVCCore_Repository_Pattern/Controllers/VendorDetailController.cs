using Microsoft.AspNetCore.Mvc;
using MVCCore_Repository_Pattern.Models;
using DataAccessRepository.Infrastructure.Repo;
using DataAccessRepository.Infrastructure.Abstract;
using DataAccessRepository.RepoModels;
using DataAccessEFCore.InfraStructureEF.AbstractEF;
using DataAccessEFCore.InfraStructureEF.RepoEF;
using DataAccessEFCore.RepoModelsEF;
using System.Collections.Generic;
using DataAccessEFCore.RepoViewModel;

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

        public IActionResult DisplayVendors()
        {
            List<VendorInformationEF> lst = _obj.GetAllVendorsSpecificFields();

            List <VendorViewModel> lstVM = new List<VendorViewModel>();

            foreach(VendorInformationEF obj in lst)
            {
                VendorViewModel objVM = new VendorViewModel();
                objVM.VID=obj.VID;
                objVM.VName = obj.VName;
                objVM.Address = obj.Address;
                lstVM.Add(objVM);
            }


            return View(lstVM);
        }

        [HttpGet]
        public IActionResult DisplayVendorCity()
        {
            VendorCityViewModel objData = _obj.GetVendorsAndCities();

            return View(objData);
        }

    }
}
