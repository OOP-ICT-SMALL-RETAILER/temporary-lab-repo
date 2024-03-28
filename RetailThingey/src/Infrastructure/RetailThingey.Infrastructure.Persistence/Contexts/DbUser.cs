namespace RetailThingey.Infrastructure.Persistence.Contexts;

// Добавил, чтобы видели, примерно какая модель конфигурируется
public class DbUser
{
    public required Guid Id { get; set; }
    public required string PasswordHash { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
}