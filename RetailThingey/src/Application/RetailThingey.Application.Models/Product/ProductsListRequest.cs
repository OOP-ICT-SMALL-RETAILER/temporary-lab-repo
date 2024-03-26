#pragma warning disable SA1516 // ElementsMustBeSeparatedByBlankLine
#pragma warning restore SA1516 // ElementsMustBeSeparatedByBlankLine

using System.Collections.ObjectModel;

namespace RetailThingey.Application.Models.Product;

public class ProductsListRequest(
    string productNameLike,
    string productCategory,
    double productPrice,
    string productSeller,
    double productRating,
    Collection<ProductModel> products)
{
    public string ProductNameLike { get; set; } = productNameLike;
    public string ProductCategory { get; set; } = productCategory;
    public double ProductPrice { get; set; } = productPrice;
    public string ProductSeller { get; set; } = productSeller;
    public double ProductRating { get; set; } = productRating;
    public Collection<ProductModel> Products { get; } = products;
}
