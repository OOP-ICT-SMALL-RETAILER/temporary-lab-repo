// <copyright file="DbCart.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThingey.Infrastructure.Persistence.Contexts;

public class DbCart
{
    public required Guid CartId { get; set; }

    public required Guid OrderId { get; set; }

    public required Guid ItemId { get; set; }

    public required int Quantity { get; set; }

    public required int Price { get; set; }
}