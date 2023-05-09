using Microsoft.AspNetCore.Mvc;
using Demo_1;
using Demo_1.Models;

namespace Demo_1.Controllers
{
    public class StudentDetailsController : Controller
    {
        Student student = new Student();
        public IActionResult Index()
        {
            List<Student> StudentsList = student.GetAllStudents();  // StudentsList --> Model Data i.e., returned from the model
            
            //After getting the data from the model to this Controller, we need to pass it to the view

            return View(StudentsList); //Passing the model data from controller to the View
        }
        public IActionResult Details(string id)     // From View Page, we always get input as string(query String)
        {
            
            Student obj_student_by_id = student.GetStudentById(Convert.ToInt32(id));
            return View(obj_student_by_id);
        }
        public IActionResult Display()
        {

            return View();
        }
    }
}
