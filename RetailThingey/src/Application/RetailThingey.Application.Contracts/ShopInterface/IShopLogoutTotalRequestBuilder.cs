using RetailThingey.Application.Models.Shop;

namespace RetailThingey.Application.Contracts.ShopInterface;

public interface IShopLogoutTotalRequestBuilder
{
    IShopLogoutTotalRequestBuilder SetEmail(string email);
    IShopLogoutTotalRequestBuilder SetPassword(string password);
    IShopLogoutTotalRequestBuilder SetMessage(string message);
    ShopLogoutTotalRequest Build();
}