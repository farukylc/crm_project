namespace WebApi.Models;

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public int Price { get; set; }
    public int RateAmount { get; set; }
    public int SalesAmount { get; set; }
    public int Cost { get; set; }

    public int Profit
    {
        get { return Price - Cost; }
    }
}