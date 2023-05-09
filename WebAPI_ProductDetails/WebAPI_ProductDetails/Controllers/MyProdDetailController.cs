using DAProductDetail.Abstract;
using DAProductDetail.RepoModel;
using DAProductDetail.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_ProductDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyProdDetailController : ControllerBase
    {
        IProdRepository _repo = new ProdRepository();
        [HttpGet]
        [Route("GetProducts")]
        public List<Product> GetProducts()
        {
            List<Product> lstProd = new List<Product>();
            lstProd = _repo.GetAllProducts();
            return lstProd;
        }
        [HttpPost]
        [Route("SaveProdData")]
        public ResponseInfo SaveProdData([FromBody]Product prod)
        {
            ResponseInfo responseInfo = new ResponseInfo();
            responseInfo = _repo.SaveProdData(prod);

            return responseInfo;
        }
        
    }
}
