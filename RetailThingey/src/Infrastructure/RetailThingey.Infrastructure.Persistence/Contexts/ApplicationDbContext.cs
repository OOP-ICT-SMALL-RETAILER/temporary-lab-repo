#pragma warning disable SA1206

using Microsoft.EntityFrameworkCore;
using RetailThingey.Application.Models;
using RetailThingey.Application.Models.Product;
using RetailThingey.Application.Models.Review;
using RetailThingey.Application.Models.Shop;

namespace RetailThings.Infrastructure.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public required DbSet<User> Users { get; set; }

    public required DbSet<ReviewModels> Reviews { get; set; }

    public required DbSet<ShopModels> Shops { get; set; }
    
    public required DbSet<ProductModel> Products { get; set; }
    
    public required DbSet<DeliveryPoint> Delivery { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        // Сюда добавлять различные конфигурации ваших файлов
        base.OnModelCreating(modelBuilder);
    }
}