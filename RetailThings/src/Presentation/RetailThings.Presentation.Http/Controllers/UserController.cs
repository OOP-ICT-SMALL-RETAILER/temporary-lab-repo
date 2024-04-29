// <copyright file="UserController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Events.Commands.User;
using RetailThings.Application.Events.Queries.User;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.User;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> Get(int id)
    {
        var query = new GetUserQuery()
        {
            UserId = id,
        };

        var user = await _mediator.Send(query);

        if (user is null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreateUserModel user)
    {
        var command = new CreateUserCommand()
        {
            CreateUserModel = user,
        };

        await _mediator.Send(command);

        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult<User>> Put(CreateUserModel user)
    {

        var command = new UpdateUserCommand()
        {
            UpdateUserModel = user,
        };

        await _mediator.Send(command);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<User>> Delete(int id)
    {
        var query = new GetUserQuery()
        {
            UserId = id,
        };

        var user = await _mediator.Send(query);

        if (user is null)
        {
            return NotFound();
        }

        var command = new DeleteUserCommand()
        {
            UserId = id,
        };

        await _mediator.Send(command);
        return Ok(user);
    }
}
