namespace WebApi.Models
{
    public enum ProductCategory
    {
        Elektronik,
        BeyazEsya,
        Kozmetik,
        Atistirmalik
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public float Stars { get; set; }
        public int SalesAmount { get; set; }
        public string imgUrl { get; set; }
        public ProductCategory Category { get; set; }
    }
}