using Microsoft.AspNetCore.Mvc;
using MVCCore_SingleTon.Utility;

namespace MVCCore_SingleTon.Controllers
{
    public class My2ndController : Controller
    {
       
        public IActionResult Index()
        {
            MyClass obj = MyClass.GetInstance();
            obj.ShowSalesDetail();

            return View();
        }
    }
}
