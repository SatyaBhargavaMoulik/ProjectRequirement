using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebAPI_Products_Consumer.Models;

namespace WebAPI_Products_Consumer.Controllers
{
    public class MyProdConsumerController : Controller
    {
        public async Task<IActionResult> Index()
        {
            string apiBaseUrl = "https://localhost:7286/";
            string endpoint = string.Empty;
            List<Product> info = null;
            using (HttpClient client = new HttpClient())
            {
                endpoint = apiBaseUrl + "api/MyProdDetail/GetProducts";
                var response = await client.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead);
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;
                    info = JsonConvert.DeserializeObject<List<Product>>(data);
                }

            }

            return View(info);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product prod)
        {
            string apiBaseUrl = "https://localhost:7286/";

            string endpoint = string.Empty;


            Product obj = new Product();
            obj.ProductName = prod.ProductName;
            obj.Price = prod.Price;

            using (HttpClient client = new HttpClient())
            {
                endpoint = apiBaseUrl + "api/MyProdDetail/SaveProdData";
                StringContent content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                var resp = await client.PostAsync(endpoint, content);

                if (resp.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ViewBag.Info = "Data saved successfully";
                }
                else
                {
                    ViewBag.Info = "Data not saved";
                }

                return View();
            }

          
        }
    }
}
