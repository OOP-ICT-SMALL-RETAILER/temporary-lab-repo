// <copyright file="ReviewController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Review;

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
    public async Task<ActionResult<Review>> Get(int id)
    {
        var review = await _reviewService.GetReviewById(id);
        if (review is null)
        {
            return NotFound();
        }
        return Ok(review);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreateReviewModel review)
    {
        await _reviewService.CreateReview(review);
        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult> Put(CreateReviewModel review)
    {
        await _reviewService.UpdateReview(review);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Review>> Delete(int id)
    {
        var review = await _reviewService.GetReviewById(id);
        if (review is null)
        {
            return NotFound();
        }
        await _reviewService.DeleteReview(id);
        return Ok(review);
    }


}
