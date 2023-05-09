using DAProductDetail.RepoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAProductDetail.Abstract
{
    public interface IProdRepository
    {
        List<Product> GetAllProducts();
        ResponseInfo SaveProdData(Product prod);

    }
}
