namespace RetailThingey.Application.Models.Product;

public class _Product(string name, string description)
{
    public int Id { get; set; }
    public string Name { get; set; } = name;
    public double CurrentPrice { get; set; }
    public string Description { get; set; } = description;
    public double Rating { get; set; }
    public bool IsListed { get; set; }
}