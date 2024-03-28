// <copyright file="ApplicationDbContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;

namespace RetailThingey.Infrastructure.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public required DbSet<DbUser> Users { get; set; }

    public required DbSet<DbReview> Reviews { get; set; }

    public required DbSet<DbCookie> Cookies { get; set; }

    public required DbSet<DbShop> Shops { get; set; }

    public required DbSet<DbOrder> Orders { get; set; }

    public required DbSet<DbCart> Carts { get; set; }

    public required DbSet<DbItem> Items { get; set; }

    public required DbSet<DbSoldCarts> SoldCarts { get; set; }

    public required DbSet<DbPickUpPoint> PickUpPoints { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}