// <copyright file="ShopController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Events.Commands.Shop;
using RetailThings.Application.Events.Queries.Shop;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Shop;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class ShopController : ControllerBase
{
    private readonly IMediator _mediator;

    public ShopController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Shop>> Get(int id)
    {
        var query = new GetShopQuery()
        {
            ShopId = id,
        };

        var shop = await _mediator.Send(query);

        if (shop is null)
        {
            return NotFound();
        }
        return Ok(shop);
    }

    [HttpPost]
    public async Task<ActionResult> Post(ShopModel shop)
    {
        var command = new CreateShopCommand()
            { ShopModel = shop };

        await _mediator.Send(command);

        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult> Put(Shop shop)
    {
        var command = new UpdateShopCommand()
            { Shop = shop };

        await _mediator.Send(command);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Shop>> Delete(int id)
    {
        var query = new GetShopQuery()
        {
            ShopId = id,
        };

        var shop = await _mediator.Send(query);

        if (shop is null)
        {
            return NotFound();
        }

        var command = new DeleteShopCommand()
            { ShopId = id };

        await _mediator.Send(command);
        return Ok(shop);
    }
}
