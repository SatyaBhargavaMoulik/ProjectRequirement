using DataAccessTier.Infrastructure.Repositary;
using DataAccessTier.Infrastructure.Abstraction;
using DataAccessTier.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework_Practice_1.Controllers
{
    public class VendorDetailsController : Controller
    {
        IVendorRepositary obj_DataAccessAbstraction = new VendorRepositary();
        public IActionResult Index()
        {
            List<Vendor> vendorslist=obj_DataAccessAbstraction.GetAllVendorDetails();

            return View(vendorslist);
        }
    }
}
