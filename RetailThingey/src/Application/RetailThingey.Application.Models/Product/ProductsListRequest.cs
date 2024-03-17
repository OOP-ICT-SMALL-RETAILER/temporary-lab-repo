using System.Collections.ObjectModel;

namespace RetailThingey.Application.Models.Product;

public class ProductsListRequest(
    string productNameLike,
    string productCategory,
    double productPrice,
    string productSeller,
    double productRating,
    Collection<_Product> products)
{
    public string ProductNameLike { get; set; } = productNameLike;
    public string ProductCategory { get; set; } = productCategory;
    public double ProductPrice { get; set; } = productPrice;
    public string ProductSeller { get; set; } = productSeller;
    public double ProductRating { get; set; } = productRating;
    public Collection<_Product> Products { get; set; } = products;
}
