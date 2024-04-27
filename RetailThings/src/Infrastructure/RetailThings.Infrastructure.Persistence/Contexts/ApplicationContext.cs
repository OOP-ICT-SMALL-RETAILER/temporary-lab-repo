// <copyright file="ApplicationContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
#pragma warning disable

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Models.Entities;

namespace RetailThings.Infrastructure.Persistence.Contexts;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions options)
        : base(options)
    {
    }

    public required DbSet<User> Users { get; set; }
    public required DbSet<Item> Items { get; set; }
    public required DbSet<ItemInOrder> ItemInOrders { get; set; }
    public required DbSet<Order> Orders { get; set; }
    public required DbSet<PaidOrder> PaidOrders { get; set; }
    public required DbSet<PickUpPoint> PickUpPoints { get; set; }
    public required DbSet<Review> Reviews { get; set; }
    public required DbSet<Shop> Shops { get; set; }

#pragma warning disable SA1600
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(user => user.UserId);
            entity.Property(user => user.Password).IsRequired();
            entity.Property(user => user.Name).IsRequired();
            entity.Property(user => user.Email).IsRequired();

            // entity.HasMany(user => user.Orders).WithOne(order => order.User);
            // entity.HasMany(user => user.Reviews).WithOne(review => review.User);
        });
        
        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(item => item.ItemId);
            entity.Property(item => item.FullPrice).IsRequired();
            entity.Property(item => item.CurrentPrice).IsRequired();
            entity.Property(item => item.Title).IsRequired();
            entity.Property(item => item.Description).IsRequired();
            entity.Property(item => item.Rating);
            entity.Property(item => item.CountOfRatings).IsRequired();
            entity.Property(item => item.Category).IsRequired();
            entity.Property(item => item.IsSale).IsRequired();


            // entity.HasOne(item => item.Shop)
            //     .WithMany(shop => shop.Items)
            //     .IsRequired();
        });

        modelBuilder.Entity<ItemInOrder>(entity =>
        {
            entity.HasKey(itemInOrder => itemInOrder.ItemInOrderId);
            entity.Property(itemInOrder => itemInOrder.Count).IsRequired();
            entity.Property(itemInOrder => itemInOrder.Price).IsRequired();

            entity.HasOne(itemInOrder => itemInOrder.Order)
                .WithMany(order => order.ItemInOrders).IsRequired();
            entity.HasOne(itemInOrder => itemInOrder.Item).WithMany().IsRequired();
            
        });
        
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(order => order.OrderId);
            entity.Property(order => order.Status).IsRequired();

            // entity.HasOne(order => order.User)
            //     .WithMany(user => user.Orders).IsRequired();
            // entity.HasOne(order => order.PickUpPoint)
            //     .WithMany(pickUpPoint => pickUpPoint.Orders).IsRequired();
            entity.HasMany(order => order.ItemInOrders)
                .WithOne(itemInOrder => itemInOrder.Order).IsRequired();
            
        });
        
        modelBuilder.Entity<PaidOrder>(entity =>
        {
            entity.HasKey(paidOrder => paidOrder.PaidOrderId);
            entity.Property(paidOrder => paidOrder.DatePaid).IsRequired();

            entity.HasOne(paidOrder => paidOrder.Order)
                .WithMany().IsRequired();
        });
        
        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(review => review.ReviewId);
            entity.Property(review => review.Rating).IsRequired();
            entity.Property(review => review.Description).IsRequired();

            // entity.HasOne(review => review.User)
            //     .WithMany(user => user.Reviews).IsRequired();
            
            entity.HasOne(review => review.Item)
                .WithMany().IsRequired();
            
        });
        
        modelBuilder.Entity<Shop>(entity =>
        {
            entity.HasKey(shop => shop.ShopId);
            entity.Property(shop => shop.Email).IsRequired();
            entity.Property(shop => shop.Password).IsRequired();
            entity.Property(shop => shop.Title).IsRequired();
            entity.Property(shop => shop.Owner).IsRequired();

            // entity.HasMany(shop => shop.Items)
            //     .WithOne(item => item.Shop);
        });
        
        modelBuilder.Entity<PickUpPoint>(entity =>
        {
            entity.HasKey(pickUpPoint => pickUpPoint.PickUpPointId);
            entity.Property(pickUpPoint => pickUpPoint.Title).IsRequired();
            entity.Property(pickUpPoint => pickUpPoint.Address).IsRequired();

            // entity.HasMany(pickUpPoint => pickUpPoint.Orders)
            //     .WithOne(order => order.PickUpPoint);
        });


        base.OnModelCreating(modelBuilder);
    }
}
