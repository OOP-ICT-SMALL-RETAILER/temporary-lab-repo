namespace RetailThingey.Application.Models.Product;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double CurrentPrice { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }
    public bool IsListed { get; set; }
}