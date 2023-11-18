namespace WebApi.Models
{
    
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public float Stars { get; set; }
        public int SalesAmount { get; set; }
        public string imgUrl { get; set; }
        
    }
}