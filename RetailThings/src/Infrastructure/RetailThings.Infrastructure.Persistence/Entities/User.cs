// <copyright file="User.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

#pragma warning disable

namespace RetailThings.Infrastructure.Persistence.Entities;
public class User
{
    public int UserId { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }
    
    public List<Order> Orders { get; set; }
    
    public List<Review> Reviews { get; set; }
    
}