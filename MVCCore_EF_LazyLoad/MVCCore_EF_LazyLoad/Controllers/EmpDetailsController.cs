using Microsoft.AspNetCore.Mvc;
using MVCCore_EF_LazyLoad.Models;

namespace MVCCore_EF_LazyLoad.Controllers
{
    public class EmpDetailsController : Controller
    {
        IEmpRepository _repo = new EmpRepository();
        public IActionResult Index()
        {
            List<Employee> employees = _repo.GetAllEmployees();
            return View(employees);
        }
    }
}
