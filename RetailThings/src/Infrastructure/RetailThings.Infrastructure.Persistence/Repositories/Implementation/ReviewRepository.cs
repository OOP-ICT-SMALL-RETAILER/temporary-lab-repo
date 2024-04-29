// <copyright file="ReviewRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Infrastructure.Persistence.Contexts;

namespace RetailThings.Infrastructure.Persistence.Repositories.Implementation;
#pragma warning disable

public class ReviewRepository : IReviewRepository
{
    private readonly ApplicationContext _applicationContext;

    public ReviewRepository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<IEnumerable<Review>> GetReviews()
    {
        return await _applicationContext.Reviews
            .Include(x => x.User)
            .Include(x => x.Item)
            .ThenInclude(x => x.Shop)
            .ToListAsync();
    }

    public async Task<Review?> GetReviewById(int reviewId)
    {
        return await _applicationContext.Reviews
            .Include(x => x.User)
            .Include(x => x.Item)
            .ThenInclude(x => x.Shop)
            .FirstOrDefaultAsync(x => x.ReviewId == reviewId);
    }

    public async Task CreateReview(Review review)
    {
        await _applicationContext.Reviews.AddAsync(review);

        await _applicationContext.SaveChangesAsync();
    }

    public async Task DeleteReview(int reviewId)
    {
        Review review = await _applicationContext.Reviews.FindAsync(reviewId);
        _applicationContext.Reviews.Remove(review);
        
        await _applicationContext.SaveChangesAsync();
    }

    public async Task UpdateReview(Review review)
    {
        _applicationContext.Entry(review).State = EntityState.Modified;
        
        await _applicationContext.SaveChangesAsync();
    }
}