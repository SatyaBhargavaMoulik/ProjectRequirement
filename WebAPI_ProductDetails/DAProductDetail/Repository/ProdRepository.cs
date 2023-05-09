using DAProductDetail.Abstract;
using DAProductDetail.RepoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAProductDetail.Repository
{
    public class ProdRepository : IProdRepository
    {
        ProdContext _context = new ProdContext();
        public List<Product> GetAllProducts()
        {
            List<Product> lst = new List<Product>();

            lst = _context.ProductsInfo.ToList();

            return lst;
        }

        public ResponseInfo SaveProdData(Product prod)
        {
            ResponseInfo responseInfo = new ResponseInfo();

            try
            {
                _context.ProductsInfo.Add(prod);
                _context.SaveChanges();

                if (prod.ProductId > 0)
                {
                    responseInfo.ResponseCode = "01";
                    responseInfo.ResponseMessage = "success";
                }
                else
                {
                    responseInfo.ResponseCode = "02";
                    responseInfo.ResponseMessage = "failed";
                }
            }
            catch(Exception ex)
            {
                responseInfo.ResponseCode = "03";
                responseInfo.ResponseMessage = "exception";
            }

            return responseInfo;
        }

    }
}
