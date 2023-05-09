namespace Factory_Pattern.Products
{
    public class VendorProduct: IProduct
    {
        public string DisplayProdDetail()
        {
            return "This is vendor product";
        }
    }
}
