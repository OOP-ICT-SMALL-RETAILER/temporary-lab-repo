using RetailThingey.Application.Models.Product;

namespace RetailThingey.Application.Contracts.ProductInterface;

public interface IProductDeleteBuilder
{
    IProductDeleteBuilder SetShopCookie(string shopCookie);
    IProductDeleteBuilder SetMessage(string message);
    ProductDelete Build();
}