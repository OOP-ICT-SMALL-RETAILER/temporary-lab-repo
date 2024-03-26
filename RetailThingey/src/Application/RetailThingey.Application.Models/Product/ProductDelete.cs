namespace RetailThingey.Application.Models.Product;

public class ProductDelete(string shopCookie, string message)
{
    public string ShopCookie { get; set; } = shopCookie;

    public string Message { get; set; } = message;
}