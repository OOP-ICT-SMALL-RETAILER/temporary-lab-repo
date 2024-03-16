namespace RetailThingey.Application.Models.Shop;

public class ShopRegistrationResponse(string shopCookie)
{
    public string ShopCookie { get; set; } = shopCookie;
}