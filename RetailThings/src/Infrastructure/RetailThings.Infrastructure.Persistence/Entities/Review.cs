// <copyright file="Review.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

public class Review
{
    public int ReviewId { get; set; }
    public User User { get; set; }
    public Item Item { get; set; }
    public double Rating { get; set; }
    public string Description { get; set; }
}