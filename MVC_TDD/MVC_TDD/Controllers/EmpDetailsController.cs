using Microsoft.AspNetCore.Mvc;
using MVC_TDD.Infrastructure;
using MVC_TDD.Models;

namespace MVC_TDD.Controllers
{
    public class EmpDetailsController : Controller
    {
        IEmpInfoRepository _repo = new EmpInfoRepository();
        public IActionResult Index()
        {
          List<Employee> lstEmp =  _repo.GetAllEmployees();
            return View(lstEmp);
        }
    }
}
