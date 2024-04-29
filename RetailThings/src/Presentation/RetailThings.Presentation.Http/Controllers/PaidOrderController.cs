// <copyright file="PaidOrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Events.Commands.PaidOrder;
using RetailThings.Application.Events.Queries.PaidOrder;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.PaidOrder;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class PaidOrderController : ControllerBase
{
    private readonly IMediator _mediator;

    public PaidOrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PaidOrder>> Get(int id)
    {
        var query = new GetPaidOrderQuery()
        {
            PaidOrderId = id,
        };

        var paidOrder = await _mediator.Send(query);

        if (paidOrder is null)
        {
            return NotFound();
        }
        return Ok(paidOrder);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreatePaidOrderModel paidOrder)
    {
        var command = new CreatePaidOrderCommand()
        {
            CreatePaidOrderModel = paidOrder,
        };

        await _mediator.Send(command);

        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult> Put(CreatePaidOrderModel paidOrder)
    {
        var command = new UpdatePaidOrderCommand()
        {
            CreatePaidOrderModel = paidOrder,
        };

        await _mediator.Send(command);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<PickUpPoint>> Delete(int id)
    {
        var query = new GetPaidOrderQuery()
        {
            PaidOrderId = id,
        };

        var paidOrder = await _mediator.Send(query);

        if (paidOrder is null)
        {
            return NotFound();
        }

        var command = new DeletePaidOrderCommand()
        {
            PaidOrderId = id,
        };

        await _mediator.Send(command);

        return Ok(paidOrder);
    }

}
