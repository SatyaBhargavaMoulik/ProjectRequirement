using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Products_Consumer.Controllers
{
    public class ClientConsumerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
