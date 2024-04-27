// <copyright file="UserController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.User;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> Get(int id)
    {
        var user = await _userService.GetUserById(id);
        if (user is null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreateUserModel user)
    {
        await _userService.CreateUser(user);
        return Ok();
    }

    
    [HttpPut]
    public async Task<ActionResult<User>> Put(CreateUserModel user)
    {
        await _userService.UpdateUser(user);
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<User>> Delete(int id)
    {
        var user = await _userService.GetUserById(id);
        if (user is null)
        {
            return NotFound();
        }
        await _userService.DeleteUser(id);
        return Ok(user);
    }
}