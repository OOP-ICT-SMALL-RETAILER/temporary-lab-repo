// <copyright file="IReviewRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Entities;

namespace RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
#pragma warning disable

public interface IReviewRepository
{
    Task<IEnumerable<Review>> GetReviews();
    Task<Review?> GetReviewById(int reviewId);
    Task CreateReview(Review review);
    Task DeleteReview(int reviewId);
    Task UpdateReview(Review review);
}
