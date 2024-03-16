namespace RetailThingey.Application.Models.Shop;

public class ShopLogoutRequest(string shopCookie, string message)
{
    public string ShopCookie { get; set; } = shopCookie;
    public string Message { get; set; } = message;
}