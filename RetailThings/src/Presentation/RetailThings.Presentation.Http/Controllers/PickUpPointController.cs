// <copyright file="PickUpPointController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;

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
    public ActionResult<PickUpPoint> Get(int id)
    {
        var pickUpPoint = _pickUpPointService.GetPickUpPointById(id);
        if (pickUpPoint == null)
        {
            return NotFound();
        }
        return Ok(pickUpPoint);
    }

    [HttpPost]
    public ActionResult<PickUpPoint> Post(PickUpPoint pickUpPoint)
    {
        _pickUpPointService.CreatePickUpPoint(pickUpPoint);
        return CreatedAtAction(nameof(Get), new { id = pickUpPoint.PickUpPointId}, pickUpPoint);
    }

    
    [HttpPut]
    public ActionResult<PickUpPoint> Put(PickUpPoint pickUpPoint)
    {
        _pickUpPointService.UpdatePickUpPoint(pickUpPoint);        
        return CreatedAtAction(nameof(Get), new { id = pickUpPoint.PickUpPointId}, pickUpPoint);
    }
    
    [HttpDelete("{id}")]
    public ActionResult<PickUpPoint> Delete(int id)
    {
        var pickUpPoint = _pickUpPointService.GetPickUpPointById(id);
        if (pickUpPoint == null)
        {
            return NotFound();
        }
        _pickUpPointService.DeletePickUpPoint(id);
        return Ok(pickUpPoint);
    } 
}