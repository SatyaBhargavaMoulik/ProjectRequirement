using MVC_Dependency_Injection.Infrastructure.Abstract;

namespace MVC_Dependency_Injection.Infrastructure.Repository
{
    public class ProdRepository : IProdRepository
    {
        public decimal GetDiscount(int proID)
        {
            decimal d = 0;

           if(proID<10)
            {
                d = 100;
            }
           else
            {
                d = 200;
            }

            return d;
        }


    }

    public class ProdRepository1 : IProdRepository
    {
        public decimal GetDiscount(int proID)
        {
            decimal d = 500;

            

            return d;
        }


    }
}
