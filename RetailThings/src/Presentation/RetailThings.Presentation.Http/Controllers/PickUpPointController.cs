// <copyright file="PickUpPointController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.PickUpPoint;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class PickUpPointController : ControllerBase
{
    private readonly IPickUpPointService _pickUpPointService;

    public PickUpPointController(IPickUpPointService pickUpPointService)
    {
        _pickUpPointService = pickUpPointService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PickUpPoint>> Get(int id)
    {
        var pickUpPoint = await _pickUpPointService.GetPickUpPointById(id);
        if (pickUpPoint is null)
        {
            return NotFound();
        }
        return Ok(pickUpPoint);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreatePickUpPointModel pickUpPoint)
    {
        await _pickUpPointService.CreatePickUpPoint(pickUpPoint);
        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult> Put(CreatePickUpPointModel pickUpPoint)
    {
        await _pickUpPointService.UpdatePickUpPoint(pickUpPoint);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<PickUpPoint>> Delete(int id)
    {
        var pickUpPoint = await _pickUpPointService.GetPickUpPointById(id);
        if (pickUpPoint is null)
        {
            return NotFound();
        }
        await _pickUpPointService.DeletePickUpPoint(id);
        return Ok(pickUpPoint);
    }
}
