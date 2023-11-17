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
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } // Yeni özellik
        public virtual Category Category { get; set; }
        
    }
}