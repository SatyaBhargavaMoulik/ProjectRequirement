using Microsoft.AspNetCore.Mvc;
using MVCCore_Basic_Architecture.Models;

namespace MVCCore_Basic_Architecture.Controllers
{
    public class StudentDetailController : Controller
    {
        Student student = new Student();
        public IActionResult Index()
        {
            List<Student> lstStud =  student.GetAllStudents();      // This lstStud is called Model Data

            return View(lstStud);  // This lstStud will be copied to the keyword "Model" in view
        }

        public IActionResult Details(string id)         // MVC gets input from view as query string
        {
            Student objStud = student.GetStudentOnRoll(Convert.ToInt32(id));

            return View(objStud);
        }
    }
}
