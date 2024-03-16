namespace RetailThingey.Application.Models;

public class User(int id, string passwordHash, string name, string email, int shippingAddressId)
{
    public int Id { get; set; } = id;
    public string PasswordHash { get; set; } = passwordHash;
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
    public int ShippingAddressId { get; set; } = shippingAddressId;
}
