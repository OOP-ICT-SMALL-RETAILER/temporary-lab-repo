// <copyright file="ItemInOrder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

public class ItemInOrder
{
    public int ItemInOrderId { get; set; }
    public Order Order { get; set; }
    public Item Item { get; set; }
    public int Count { get; set; }
    public double Price { get; set; }
}