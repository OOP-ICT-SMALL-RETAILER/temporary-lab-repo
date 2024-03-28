// <copyright file="DbShop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThingey.Infrastructure.Persistence.Contexts;

public class DbShop
{
    public required Guid Id { get; set; }

    public required string Email { get; set; }

    public required string PasswordHash { get; set; }

    public required string Name { get; set; }

    public required string Owner { get; set; }
}