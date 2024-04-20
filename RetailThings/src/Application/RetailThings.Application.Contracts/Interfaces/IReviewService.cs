// <copyright file="IReviewService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Application.Contracts.Interfaces;
#pragma warning disable

public interface IReviewService
{
    IEnumerable<Review> GetReviews();
    Review GetReviewById(int reviewId);
    void CreateReview(Review review);
    void DeleteReview(int reviewId);
    void UpdateReview(Review review);
}