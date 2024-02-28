using RetailThingey.Application.Models.Product;

namespace RetailThingey.Application.Contracts.ProductInterface;

public interface IProductInfoResponseBuilder
{
    IProductInfoResponseBuilder SetId(int id);
    IProductInfoResponseBuilder SetName(string name);
    IProductInfoResponseBuilder SetCurrentPrice(double currentPrice);
    IProductInfoResponseBuilder SetDescription(string description);
    IProductInfoResponseBuilder SetRating(double rating);
    IProductInfoResponseBuilder SetIsListed(bool isListed);
    ProductInfoResponse Build();
}