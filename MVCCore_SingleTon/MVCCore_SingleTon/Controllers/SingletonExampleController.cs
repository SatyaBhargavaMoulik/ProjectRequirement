using Microsoft.AspNetCore.Mvc;
using MVCCore_SingleTon.Utility;

namespace MVCCore_SingleTon.Controllers
{
    public class SingletonExampleController : Controller
    {
       
        public IActionResult Index()
        {
            MyClass obj = MyClass.GetInstance();
            obj.ShowSalesDetail();

            return RedirectToAction("Index", "My2nd");
        }


       

    }
}
