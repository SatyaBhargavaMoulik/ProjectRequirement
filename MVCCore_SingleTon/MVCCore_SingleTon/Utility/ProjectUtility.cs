namespace MVCCore_SingleTon.Utility
{



    public sealed class MyClass
    {

        public static MyClass obj1 = null;

        public static MyClass GetInstance()
        {
            if (obj1 == null)
            {
                obj1 = new MyClass();
            }


            return obj1;
        }




        public void ShowSalesDetail()
        {
            int salesQty = 100;
            int salesPrice = 500;
            int amt = salesQty * salesPrice;
        }


    }






}
