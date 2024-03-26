using RetailThingey.Application.Models.Shop;

namespace RetailThingey.Application.Contracts.ShopInterface;

public interface IShopBuilder
{
    IShopBuilder SetName(string name);
    IShopBuilder SetEmail(string email);
    IShopBuilder SetPassword(string password);
    ShopModels Build();
}