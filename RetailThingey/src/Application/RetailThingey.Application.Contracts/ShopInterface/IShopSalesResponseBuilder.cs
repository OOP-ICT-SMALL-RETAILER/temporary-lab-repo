using RetailThingey.Application.Models.Shop;

namespace RetailThingey.Application.Contracts.ShopInterface;

public interface IShopSalesResponseBuilder
{
    IShopSalesResponseBuilder SetSales(Dictionary<string, string> sales);
    ShopSalesResponse Build();
}