namespace Factory_Pattern.Products
{
    public class ProductFactory
    {
        public IProduct GetProductInstance(int pCatID)
        {
            IProduct pRef = null;

            try
            {
                if(pCatID == 1)
                {
                    pRef = new InhouseProduct();
                }
                else if(pCatID==2)
                {
                    pRef = new VendorProduct();
                }


            }
            catch(Exception ex)
            {

            }


            return pRef;
        }

    }
}
