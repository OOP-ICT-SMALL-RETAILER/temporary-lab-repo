namespace RetailThingey.Application.Models.Product;

public class ProductRequest(
    string shopCookie,
    string name,
    double price,
    string description,
    int salePercentage,
    bool delisted,
    string productId)
{
    public string ShopCookie { get; set; } = shopCookie;
    public string Name { get; set; } = name;
    public double Price { get; set; } = price;
    public string Description { get; set; } = description;

    public int SalePercentage { get; set; } = salePercentage;
    public bool Delisted { get; set; } = delisted;
    public string ProductId { get; set; } = productId;
}