namespace WebApi.Models;

public class CustomerProfileViewModel
{
    public Customer Customer { get; set; }
    public List<Order> Orders { get; set; }
    public List<Comment> Comments { get; set; }
}
