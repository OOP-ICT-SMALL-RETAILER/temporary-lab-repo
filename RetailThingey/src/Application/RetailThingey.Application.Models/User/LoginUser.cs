namespace RetailThingey.Application.Models;

public class LoginUser(string email, string password)
{
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
}