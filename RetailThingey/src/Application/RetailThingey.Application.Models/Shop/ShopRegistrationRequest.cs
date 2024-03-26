#pragma warning disable SA1516 // ElementsMustBeSeparatedByBlankLine
#pragma warning restore SA1516 // ElementsMustBeSeparatedByBlankLine

namespace RetailThingey.Application.Models.Shop;

public class ShopRegistrationRequest(string name, string email, string password)
{
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
}