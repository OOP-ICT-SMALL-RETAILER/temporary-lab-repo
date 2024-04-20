// <copyright file="PickUpPoint.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

public class PickUpPoint
{
    public int PickUpPointId { get; set; }
    public string Title { get; set; }
    public string Address { get; set; }
    public List<Order> Orders { get; set; }
}