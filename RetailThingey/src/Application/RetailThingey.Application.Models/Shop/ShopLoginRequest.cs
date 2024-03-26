namespace RetailThingey.Application.Models.Shop;

#pragma warning disable SA1516 // ElementsMustBeSeparatedByBlankLine
#pragma warning restore SA1516 // ElementsMustBeSeparatedByBlankLine

public class ShopLoginRequest(string email, string password)
{
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
}