#pragma warning disable SA1516 // ElementsMustBeSeparatedByBlankLine
#pragma warning restore SA1516 // ElementsMustBeSeparatedByBlankLine
namespace RetailThingey.Application.Models.Shop;

public class ShopLogoutTotalRequest(string email, string password, string message)
{
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
    public string Message { get; set; } = message;
}