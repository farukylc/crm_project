namespace WebApi.Models;

public class Comment
{
    public int CommentID { get; set; }
    public string Text { get; set; }
    public DateTime CommentDate { get; set; }

    //navigation property
    public int CustomerID { get; set; } 


    public virtual Customer Customer { get; set; }
    
}