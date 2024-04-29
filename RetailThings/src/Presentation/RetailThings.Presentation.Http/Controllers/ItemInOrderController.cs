// <copyright file="ItemInOrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Events.Commands.ItemInOrder;
using RetailThings.Application.Events.Queries.ItemInOrder;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.ItemInOrder;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class ItemInOrderController : ControllerBase
{
    private readonly IMediator _mediator;

    public ItemInOrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ItemInOrder>> Get(int id)
    {
        var query = new GetItemInOrderQuery()
        {
            ItemInOrderId = id,
        };

        var itemInOrder = await _mediator.Send(query);

        if (itemInOrder is null)
        {
            return NotFound();
        }
        return Ok(itemInOrder);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreateItemInOrderModel itemInOrder)
    {
        var command = new CreateItemInOrderCommand()
        {
            CreateItemInOrderModel = itemInOrder,
        };

        await _mediator.Send(command);

        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult<ItemInOrder>> Put(CreateItemInOrderModel itemInOrder)
    {
        var command = new UpdateItemInOrderCommand()
        {
            CreateItemInOrderModel = itemInOrder,
        };

        await _mediator.Send(command);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ItemInOrder>> Delete(int id)
    {
        var query = new GetItemInOrderQuery()
            { ItemInOrderId = id };

        var itemInOrder = await _mediator.Send(query);

        if (itemInOrder is null)
        {
            return NotFound();
        }

        var command = new DeleteItemInOrderCommand()
        {
            ItemInOrderId = id,
        };

        await _mediator.Send(command);

        return Ok(itemInOrder);
    }


}
