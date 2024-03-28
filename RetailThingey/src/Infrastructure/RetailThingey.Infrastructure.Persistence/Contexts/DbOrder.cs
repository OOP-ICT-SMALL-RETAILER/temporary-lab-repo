// <copyright file="DbOrder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThingey.Infrastructure.Persistence.Contexts;

public class DbOrder
{
    public required Guid Id { get; set; }

    public required Guid OwnerId { get; set; }

    public required Guid PickUpPointId { get; set; }

    public required string OrderState { get; set; }
}