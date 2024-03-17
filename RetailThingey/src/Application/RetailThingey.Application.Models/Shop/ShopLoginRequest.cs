namespace RetailThingey.Application.Models.Shop;

public class ShopLoginRequest(string email, string password)
{
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
}