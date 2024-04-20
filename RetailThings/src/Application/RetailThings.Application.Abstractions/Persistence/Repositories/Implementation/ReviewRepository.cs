// <copyright file="ReviewRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Contexts;
using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Application.Contracts.Implementation;
#pragma warning disable

public class ReviewRepository : IReviewRepository
{
    private ApplicationContext _applicationContext;
    private bool disposed = false;

    public ReviewRepository(ApplicationContext applicationContext)
    {
        _applicationContext = _applicationContext;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _applicationContext.Dispose();
            }
        }
        disposed = true;
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public IEnumerable<Review> GetReviews()
    {
        return _applicationContext.Reviews.ToList();
    }

    public Review GetReviewById(int reviewId)
    {
        return _applicationContext.Reviews.Find(reviewId);
    }

    public void CreateReview(Review review)
    {
        _applicationContext.Reviews.Add(review);
    }

    public void DeleteReview(int reviewId)
    {
        Review review = _applicationContext.Reviews.Find(reviewId);
        _applicationContext.Reviews.Remove(review);
    }

    public void UpdateReview(Review review)
    {
        _applicationContext.Entry(review).State = EntityState.Modified;
    }

    public void Save()
    {
        _applicationContext.SaveChanges();
    }
}