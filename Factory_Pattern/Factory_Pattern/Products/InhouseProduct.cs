namespace Factory_Pattern.Products
{
    public class InhouseProduct: IProduct
    {
        public string DisplayProdDetail()
        {
            return "This is inhouse product";
        }
    }
}
