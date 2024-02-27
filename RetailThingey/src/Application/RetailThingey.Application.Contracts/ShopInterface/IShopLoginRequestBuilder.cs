using RetailThingey.Application.Models.Shop;

namespace RetailThingey.Application.Contracts.ShopInterface;

public interface IShopLoginRequestBuilder
{
    IShopLoginRequestBuilder SetEmail(string email);
    IShopLoginRequestBuilder SetPassword(string password);
    ShopLoginRequest Build();
}