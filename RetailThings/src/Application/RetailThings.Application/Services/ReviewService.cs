// <copyright file="ReviewService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Review;

namespace RetailThings.Application.Services;
#pragma warning disable

public class ReviewService : IReviewService
{
    private readonly IReviewRepository _reviewRepository;

    public ReviewService(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }

    public async Task<IEnumerable<GetReviewModel>> GetReviews()
    {
        return (await _reviewRepository.GetReviews())
            .Select(result => new GetReviewModel
            {
                ReviewId = result.ReviewId,
                User = result.User,
                Item = result.Item,
                Rating = result.Rating,
                Description = result.Description,
            });
    }

    public async Task<GetReviewModel?> GetReviewById(int reviewId)
    {
        var result = await _reviewRepository.GetReviewById(reviewId);

        if (result is null)
            return null;

        return new GetReviewModel
        {
            ReviewId = result.ReviewId,
            User = result.User,
            Item = result.Item,
            Rating = result.Rating,
            Description = result.Description,
        };
    }

    public async Task CreateReview(CreateReviewModel review)
    {
        await _reviewRepository.CreateReview(new Review()
        {
            UserId = review.UserId,
            ItemId = review.ItemId,
            Rating = review.Rating,
            Description = review.Description,
        });
    }

    public async Task DeleteReview(int reviewId)
    {
        await _reviewRepository.DeleteReview(reviewId);
    }

    public async Task UpdateReview(CreateReviewModel review)
    {
        await _reviewRepository.UpdateReview(new Review()
        {
            UserId = review.UserId,
            ItemId = review.ItemId,
            Rating = review.Rating,
            Description = review.Description,
        });
    }
}
