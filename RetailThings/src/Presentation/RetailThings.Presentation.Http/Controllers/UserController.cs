// <copyright file="UserController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;

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
    public ActionResult<User> Get(int id)
    {
        var user = _userService.GetUserById(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public ActionResult<User> Post(User user)
    {
        _userService.CreateUser(user);
        return CreatedAtAction(nameof(Get), new { id = user.UserId }, user);
    }

    
    [HttpPut]
    public ActionResult<User> Put(User user)
    {
        _userService.UpdateUser(user);
        return CreatedAtAction(nameof(Get), new { id = user.UserId }, user);
    }
    
    [HttpDelete("{id}")]
    public ActionResult<User> Delete(int id)
    {
        var user = _userService.GetUserById(id);
        if (user == null)
        {
            return NotFound();
        }
        _userService.DeleteUser(id);
        return Ok(user);
    }
}