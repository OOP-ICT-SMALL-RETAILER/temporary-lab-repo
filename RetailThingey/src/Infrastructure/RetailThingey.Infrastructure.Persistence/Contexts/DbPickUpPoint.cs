// <copyright file="DbPickUpPoint.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThingey.Infrastructure.Persistence.Contexts;

public class DbPickUpPoint
{
    public required Guid PointId { get; set; }

    public required string PointName { get; set; }

    public required string PointAdress { get; set; }
}