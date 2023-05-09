using Microsoft.AspNetCore.Mvc;
using Razor_HTML_Form_Control.Models;

namespace Razor_HTML_Form_Control.Controllers
{
    public class HTML_Form_Eleents_Controller : Controller
    {
        Employee emp_obj = new Employee();

        [HttpGet]
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>();
            employees = emp_obj.GetAllEmployees();
            return View(employees);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            return View();
        }
    }
}
