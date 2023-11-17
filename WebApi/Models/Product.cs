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
        
        public string Category { get; set; }
       
        public ICollection<Comment> Comments { get; set; }
        public Customer Customer { get; set; }
    }
}