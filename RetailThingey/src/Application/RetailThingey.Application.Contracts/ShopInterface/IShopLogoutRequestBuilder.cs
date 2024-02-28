using RetailThingey.Application.Models.Shop;

namespace RetailThingey.Application.Contracts.ShopInterface;

public interface IShopLogoutRequestBuilder
{
    IShopLogoutRequestBuilder SetShopCookie(string shopCookie);
    ShopLogoutRequest Build();
}