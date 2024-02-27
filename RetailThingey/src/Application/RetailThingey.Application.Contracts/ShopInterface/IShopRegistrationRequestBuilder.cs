using RetailThingey.Application.Models.Shop;

namespace RetailThingey.Application.Contracts.ShopInterface;

public interface IShopRegistrationRequestBuilder
{
    IShopRegistrationRequestBuilder SetName(string name);
    IShopRegistrationRequestBuilder SetEmail(string email);
    IShopRegistrationRequestBuilder SetPassword(string password);
    ShopRegistrationRequest Build();
}