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
    }
}
