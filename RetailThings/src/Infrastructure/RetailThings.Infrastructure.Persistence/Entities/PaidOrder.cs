// <copyright file="PaidOrder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

public class PaidOrder
{
    public int PaidOrderId { get; set; }
    public Order Order { get; set; }
    public DateTime DatePaid { get; set; } = DateTime.Now;
}