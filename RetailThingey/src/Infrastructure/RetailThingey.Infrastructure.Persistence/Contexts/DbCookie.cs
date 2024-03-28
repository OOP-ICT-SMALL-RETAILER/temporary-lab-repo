// <copyright file="Cookie.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThingey.Infrastructure.Persistence.Contexts;

public class DbCookie
{
    public required Guid Id { get; set; }
    public required Guid UserId { get; set; }
    public required DateOnly RegisterTime { get; set; }
    public required string CookieText { get; set; }
    public bool IsActive { get; set; } = true;
}