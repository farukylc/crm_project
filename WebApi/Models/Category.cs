using WebApi.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; } // Nullable hale getirildi

    // İlişkili ürünleri tutmak için navigasyon özelliği
    public virtual ICollection<Product> Products { get; set; }
}