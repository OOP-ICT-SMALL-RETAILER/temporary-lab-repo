using RetailThingey.Application.Models.Shop;

namespace RetailThingey.Application.Contracts.ShopInterface;

public interface IShopRegistrationResponseBuilder
{
    IShopRegistrationResponseBuilder SetShopCookie(string shopCookie);
    ShopRegistrationResponse Build();
}