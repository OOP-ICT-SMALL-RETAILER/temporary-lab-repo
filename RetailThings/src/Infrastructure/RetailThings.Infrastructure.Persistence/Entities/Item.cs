// <copyright file="Item.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

public class Item
{
    public int ItemId { get; set; }
    public Shop Shop { get; set; }
    public double FullPrice { get; set; }
    public double CurrentPrice { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }
    public int CountOfRatings { get; set; }
    public string Category { get; set; }
    public bool IsSale { get; set; }
    
}