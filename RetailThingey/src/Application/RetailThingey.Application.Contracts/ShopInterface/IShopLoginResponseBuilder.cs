using RetailThingey.Application.Models.Shop;

namespace RetailThingey.Application.Contracts.ShopInterface;

public interface IShopLoginResponseBuilder
{
    IShopLoginResponseBuilder SetShopCookie(string shopCookie);
    ShopLoginResponse Build();
}