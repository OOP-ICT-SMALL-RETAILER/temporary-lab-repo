namespace RetailThingey.Application.Models.Product;

public class ProductRequest
{
    public string ShopCookie { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public int SalePercentage { get; set; }
    public bool Delisted { get; set; }
    public string ProductId { get; set; }
}