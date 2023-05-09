using DA_EFCore.Abstract;
using DA_EFCore.Model;
using DA_EFCore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MVC_EFCore_DBFirst.Controllers
{
    public class EmplDetailsController : Controller
    {
        IEmpInfoRepository _repo = new EmpInfoRepository();
        public IActionResult Index()
        {
          List<Employee> lstEmp =  _repo.GetAllEmployee();

            return View(lstEmp);
        }
    }
}
