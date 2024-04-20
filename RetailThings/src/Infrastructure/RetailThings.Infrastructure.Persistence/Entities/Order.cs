// <copyright file="Order.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

public class Order
{
    public int OrderId { get; set; }
    public User User { get; set; }
    public PickUpPoint PickUpPoint { get; set; }
    public string Status { get; set; }
    public List<ItemInOrder> ItemInOrders { get; set; }
}