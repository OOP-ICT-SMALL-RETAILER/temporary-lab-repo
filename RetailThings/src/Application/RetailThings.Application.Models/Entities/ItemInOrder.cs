// <copyright file="ItemInOrder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations.Schema;

namespace RetailThings.Application.Models.Entities;
#pragma warning disable

public class ItemInOrder
{
    [Column("ItemInOrderId")]
    public int ItemInOrderId { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int ItemId { get; set; }
    public Item Item { get; set; }
    public int Count { get; set; }
    public double Price { get; set; }
}
