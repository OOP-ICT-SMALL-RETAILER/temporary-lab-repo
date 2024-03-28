// <copyright file="Review.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace RetailThingey.Infrastructure.Persistence.Contexts;

public class DbReview
{
    public required Guid Id { get; set; }
    public required Guid UserId { get; set; }
    public required Guid ItemId { get; set; }
    public required float Ranking { get; set; }
    public required string ReviewText { get; set; }
}