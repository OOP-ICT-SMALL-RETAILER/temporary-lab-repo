// <copyright file="ReviewController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class ReviewController : ControllerBase
{
    private readonly IReviewService _reviewService;

    public ReviewController(IReviewService reviewService)
    {
        _reviewService = reviewService;
    }
    
    [HttpGet("{id}")]
    public ActionResult<Review> Get(int id)
    {
        var review = _reviewService.GetReviewById(id);
        if (review == null)
        {
            return NotFound();
        }
        return Ok(review);
    }

    [HttpPost]
    public ActionResult<Review> Post(Review review)
    {
        _reviewService.CreateReview(review);
        return CreatedAtAction(nameof(Get), new { id = review.ReviewId }, review);
    }

    
    [HttpPut]
    public ActionResult<Review> Put(Review review)
    {
        _reviewService.UpdateReview(review);        
        return CreatedAtAction(nameof(Get), new { id = review.ReviewId }, review);
    }
    
    [HttpDelete("{id}")]
    public ActionResult<Review> Delete(int id)
    {
        var review = _reviewService.GetReviewById(id);
        if (review == null)
        {
            return NotFound();
        }
        _reviewService.DeleteReview(id);
        return Ok(review);
    } 
    
    
}