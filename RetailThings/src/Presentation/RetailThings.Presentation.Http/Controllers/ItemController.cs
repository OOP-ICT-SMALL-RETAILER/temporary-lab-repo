// <copyright file="ItemController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Events.Commands.Items;
using RetailThings.Application.Events.Queries.Items;
using RetailThings.Application.Models.Item;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    private readonly IMediator _mediator;

    public ItemController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetItemModel>> Get(int id)
    {
        var query = new GetItemQuery
        {
            ItemId = id,
        };

        var item = await _mediator.Send(query);

        if (item is null)
        {
            return NotFound();
        }
        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreateItemModel createItem)
    {
        var command = new CreateItemCommand()
        {
            CreateItemModel = createItem,
        };

        await _mediator.Send(command);
        return Created();
    }


    [HttpPut]
    public async Task<ActionResult> Put(CreateItemModel createItem)
    {
        var command = new UpdateItemCommand()
        {
            CreateItemModel = createItem,
        };

        await _mediator.Send(command);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<GetItemModel>> Delete(int id)
    {
        var query = new GetItemQuery()
        {
            ItemId = id,
        };

        var item = await _mediator.Send(query);

        if (item is null)
        {
            return NotFound();
        }

        var command = new DeleteItemCommand()
        {
            ItemId = id,
        };

        await _mediator.Send(command);
        return Ok(item);
    }


}
