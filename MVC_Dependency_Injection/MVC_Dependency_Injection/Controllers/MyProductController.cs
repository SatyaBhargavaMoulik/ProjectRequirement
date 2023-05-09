using Microsoft.AspNetCore.Mvc;
using MVC_Dependency_Injection.Infrastructure.Abstract;

namespace MVC_Dependency_Injection.Controllers
{
    public class MyProductController : Controller
    {
        IProdRepository _repo = null;

        public MyProductController(IProdRepository repo)        // Here your middleware is injecting that line "=new ProdRepository();"
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
          decimal dc =  _repo.GetDiscount(3);

            ViewBag.DiscountAmount = dc;

            return View();
        }
    }
}
