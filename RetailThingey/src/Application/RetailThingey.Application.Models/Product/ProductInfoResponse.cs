namespace RetailThingey.Application.Models.Product;

public class ProductInfoResponse(
    int id,
    string name,
    double currentPrice,
    string description,
    double rating,
    bool isListed)
{
    public int Id { get; set; } = id;

    public string Name { get; set; } = name;
    public double CurrentPrice { get; set; } = currentPrice;
    public string Description { get; set; } = description;
    public double Rating { get; set; } = rating;
    public bool IsListed { get; set; } = isListed;
}