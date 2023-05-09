using Microsoft.AspNetCore.Mvc;
using MVCCore_Repository_Pattern.Models;
using DataAccessRepository.Infrastructure.Repo;
using DataAccessRepository.Infrastructure.Abstract;
using DataAccessRepository.RepoModels;

namespace MVCCore_Repository_Pattern.Controllers
{
    public class VendorDetailController : Controller
    {
        IVendorInformationRepository _obj = new VendorInformationRepository();
        public IActionResult Index()
        {
          List<VendorInformation> lst =  _obj.GetAllVendors();


            return View(lst);
        }
    }
}
