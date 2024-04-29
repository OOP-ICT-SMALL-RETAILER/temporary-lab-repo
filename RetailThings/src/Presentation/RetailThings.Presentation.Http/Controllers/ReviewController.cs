// <copyright file="ReviewController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Events.Commands.Review;
using RetailThings.Application.Events.Queries.Review;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Review;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class ReviewController : ControllerBase
{
    private readonly IMediator _mediator;

    public ReviewController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Review>> Get(int id)
    {
        var query = new GetReviewQuery()
        {
            ReviewId = id,
        };

        var review = await _mediator.Send(query);

        if (review is null)
        {
            return NotFound();
        }
        return Ok(review);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreateReviewModel review)
    {
        var command = new CreateReviewCommand()
        {
            CreateReviewModel = review,
        };

        await _mediator.Send(command);

        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult> Put(CreateReviewModel review)
    {
        var command = new UpdateReviewCommand()
        {
            UpdateReviewModel = review,
        };

        await _mediator.Send(command);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Review>> Delete(int id)
    {
        var query = new GetReviewQuery()
        {
            ReviewId = id,
        };

        var review = await _mediator.Send(query);

        if (review is null)
        {
            return NotFound();
        }

        var command = new DeleteReviewCommand()
        {
            ReviewId = id,
        };

        await _mediator.Send(command);

        return Ok(review);
    }


}
