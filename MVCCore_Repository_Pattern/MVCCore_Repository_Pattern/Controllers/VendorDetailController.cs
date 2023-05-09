using Microsoft.AspNetCore.Mvc;
using MVCCore_Repository_Pattern.Models;
using MVCCore_Repository_Pattern.Repository;

namespace MVCCore_Repository_Pattern.Controllers
{
    public class VendorDetailController : Controller
    {
        IVendorInfoRepository _obj = new VendorInfoRepository();
        public IActionResult Index()
        {
          List<Vendor> lst =  _obj.GetAllVendors();


            return View(lst);
        }
    }
}
