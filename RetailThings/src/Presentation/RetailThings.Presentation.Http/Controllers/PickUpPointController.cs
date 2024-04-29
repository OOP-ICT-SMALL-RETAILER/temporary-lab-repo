// <copyright file="PickUpPointController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Events.Commands.PickUp;
using RetailThings.Application.Events.Queries.PickUp;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.PickUpPoint;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class PickUpPointController : ControllerBase
{
    private readonly IMediator _mediator;

    public PickUpPointController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PickUpPoint>> Get(int id)
    {
        var query = new GetPickUpQuery()
        {
            PickUpPointId = id,
        };

        var pickUpPoint = await _mediator.Send(query);

        if (pickUpPoint is null)
        {
            return NotFound();
        }
        return Ok(pickUpPoint);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreatePickUpPointModel pickUpPoint)
    {
        var command = new CreatePickUpCommand()
        {
            PickUpPoint = pickUpPoint,
        };

        await _mediator.Send(command);

        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult> Put(CreatePickUpPointModel pickUpPoint)
    {
        var command = new UpdatePickUpCommand()
        {
            PickUpPoint = pickUpPoint
        };

        await _mediator.Send(command);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<PickUpPoint>> Delete(int id)
    {
        var query = new GetPickUpQuery()
        {
            PickUpPointId = id,
        };

        var pickUpPoint = await _mediator.Send(query);

        if (pickUpPoint is null)
        {
            return NotFound();
        }

        var command = new DeletePickUpCommand()
        {
            PickUpPointId = id,
        };

        await _mediator.Send(command);
        
        return Ok(pickUpPoint);
    }
}
