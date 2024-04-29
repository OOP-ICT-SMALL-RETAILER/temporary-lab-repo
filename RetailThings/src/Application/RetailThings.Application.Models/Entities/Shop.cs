// <copyright file="Shop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.ComponentModel.DataAnnotations.Schema;

namespace RetailThings.Application.Models.Entities;
#pragma warning disable

public class Shop
{
    [Column("ShopId")]
    public int ShopId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Title { get; set; }
    public string Owner { get; set; }
}