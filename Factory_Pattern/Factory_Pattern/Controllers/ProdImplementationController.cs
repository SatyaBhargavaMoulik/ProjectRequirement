using Factory_Pattern.Products;
using Microsoft.AspNetCore.Mvc;

namespace Factory_Pattern.Controllers
{
    public class ProdImplementationController : Controller
    {
        IProduct pRef = null;
        ProductFactory objProd = new ProductFactory();
        public IActionResult Index()
        {
            pRef = objProd.GetProductInstance(1);
            string str = pRef.DisplayProdDetail();
            return View();
        }

        public IActionResult OtherFn()
        {
            pRef = objProd.GetProductInstance(2);
            string str = pRef.DisplayProdDetail();

            return View();
        }
    }
}
