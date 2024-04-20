// <copyright file="Shop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

public class Shop
{
    public int ShopId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Title { get; set; }
    public string Owner { get; set; }
    public List<Item> Items { get; set; }
}