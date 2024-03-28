// <copyright file="DbSoldCarts.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThingey.Infrastructure.Persistence.Contexts;

public class DbSoldCarts
{
    public required Guid TransactionId { get; set; }

    public required Guid OrderId { get; set; }

    public required DateOnly PaymentDate { get; set; }
}