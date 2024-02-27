using RetailThingey.Application.Models.Product;

namespace RetailThingey.Application.Contracts.ProductInterface;

public interface IProductRequestBuilder
{
    IProductRequestBuilder SetShopCookie(string shopCookie);
    IProductRequestBuilder SetName(string name);
    IProductRequestBuilder SetPrice(double price);
    IProductRequestBuilder SetDescription(string description);
    IProductRequestBuilder SetSalePercentage(int salePercentage);
    IProductRequestBuilder SetDelisted(bool delisted);
    IProductRequestBuilder SetProductId(string productId);
    ProductRequest Build();
}