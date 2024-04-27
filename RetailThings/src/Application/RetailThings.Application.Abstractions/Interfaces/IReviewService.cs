// <copyright file="IReviewService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Review;

namespace RetailThings.Application.Abstractions.Interfaces;
#pragma warning disable

public interface IReviewService
{
    Task<IEnumerable<GetReviewModel>> GetReviews();
    Task<GetReviewModel?> GetReviewById(int reviewId);
    Task CreateReview(CreateReviewModel review);
    Task DeleteReview(int reviewId);
    Task UpdateReview(CreateReviewModel review);
}