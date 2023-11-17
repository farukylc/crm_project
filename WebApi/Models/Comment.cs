namespace WebApi.Models;

public class Comment
{
    public int CommentID { get; set; }
    public string Text { get; set; }
    public DateTime CommentDate { get; set; }

    // Reference to Customer
    public int CustomerID { get; set; }
    public Customer Customer { get; set; }

    // Reference to Product
    public int ProductID { get; set; }
    public Product Product { get; set; }
}