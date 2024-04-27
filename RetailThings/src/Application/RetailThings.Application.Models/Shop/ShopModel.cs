namespace RetailThings.Application.Models.Shop;

public record ShopModel
{
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Title { get; set; }
    public required string Owner { get; set; }
}
