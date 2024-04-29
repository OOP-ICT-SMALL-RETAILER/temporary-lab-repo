namespace RetailThings.Application.Models.User;

public record CreateUserModel
{
    public required string Password { get; set; }

    public required string Name { get; set; }

    public required string Email { get; set; }
}
