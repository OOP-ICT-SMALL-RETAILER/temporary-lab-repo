// <copyright file="DbItem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThingey.Infrastructure.Persistence.Contexts;

public class DbItem
{
    public required Guid Id { get; set; }

    public required Guid ShopId { get; set; }

    public required int FullPrice { get; set; }

    public required float CurrentPricePercent { get; set; }

    public required string ItemName { get; set; }

    public required string ItemDescription { get; set; }

    public required string ItemCategory { get; set; }

    public bool IsAvailable { get; set; } = true;
}