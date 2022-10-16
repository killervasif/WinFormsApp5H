namespace WinFormsApp5H
{
    public class FakeRepo
    {
        public static List<Product> GetProducts()
        {
            return new()
            {
                new Product("Crax",1,20),
                new Product("Ayran",0.8,0),
                new Product("Cola",0.8,11),
                new Product("Pringles",2.5,18),                
            };
        }    
    }
}