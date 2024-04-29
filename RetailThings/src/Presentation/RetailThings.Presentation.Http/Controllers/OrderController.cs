// <copyright file="OrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Events.Commands.Order;
using RetailThings.Application.Events.Queries.Order;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Order;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Order>> Get(int id)
    {
        var query = new GetOrderQuery()
        {
            OrderId = id,
        };

        var order = await _mediator.Send(query);

        if (order is null)
        {
            return NotFound();
        }
        return Ok(order);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreateOrderModel order)
    {
        var command = new CreateOrderCommand()
        {
            CreateOrderModel = order,
        };

        await _mediator.Send(command);

        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult> Put(CreateOrderModel order)
    {
        var command = new UpdateOrderCommand()
        {
            CreateOrderModel = order,
        };

        await _mediator.Send(command);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Order>> Delete(int id)
    {
        var query = new GetOrderQuery()
        {
            OrderId = id,
        };

        var order = await _mediator.Send(query);
        
        if (order is null)
        {
            return NotFound();
        }
        
        var command = new DeleteOrderCommand()
        {
            OrderId = id,
        };

        await _mediator.Send(command);
        
        return Ok(order);
    }

}
