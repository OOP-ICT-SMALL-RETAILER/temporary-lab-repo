namespace RetailThingey.Application.Models.Shop;

public class ShopLoginResponse(string shopCookie)
{
    public string ShopCookie { get; set; } = shopCookie;
}