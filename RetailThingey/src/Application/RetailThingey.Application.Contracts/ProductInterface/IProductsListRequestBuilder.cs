using RetailThingey.Application.Models.Product;

namespace RetailThingey.Application.Contracts.ProductInterface;

public interface IProductsListRequestBuilder
{
    IProductsListRequestBuilder SetProductNameLike(string productNameLike);
    IProductsListRequestBuilder SetProductCategory(string productCategory);
    IProductsListRequestBuilder SetProductPrice(double productPrice);
    IProductsListRequestBuilder SetProductSeller(string productSeller);
    IProductsListRequestBuilder SetProductRating(double productRating);
    IProductsListRequestBuilder SetProducts(IList<ProductModel> products);
    ProductsListRequest Build();
}