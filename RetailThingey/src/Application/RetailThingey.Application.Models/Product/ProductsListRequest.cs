namespace RetailThingey.Application.Models.Product;

public class ProductsListRequest
{
    public string ProductNameLike { get; set; }
    public string ProductCategory { get; set; }
    public double ProductPrice { get; set; }
    public string ProductSeller { get; set; }
    public double ProductRating { get; set; }
    public List<Product> Products { get; set; }
}