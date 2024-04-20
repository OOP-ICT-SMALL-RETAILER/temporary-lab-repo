// <copyright file="PaidOrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class PaidOrderController : ControllerBase
{
    private readonly IPaidOrderService _paidOrderService;

    public PaidOrderController(IPaidOrderService paidOrderService)
    {
        _paidOrderService = paidOrderService;
    }
    
    [HttpGet("{id}")]
    public ActionResult<PaidOrder> Get(int id)
    {
        var paidOrder = _paidOrderService.GetPaidOrderById(id);
        if (paidOrder == null)
        {
            return NotFound();
        }
        return Ok(paidOrder);
    }

    [HttpPost]
    public ActionResult<PaidOrder> Post(PaidOrder paidOrder)
    {
        _paidOrderService.CreatePaidOrder(paidOrder);
        return CreatedAtAction(nameof(Get), new { id = paidOrder.PaidOrderId}, paidOrder);
    }

    
    [HttpPut]
    public ActionResult<PaidOrder> Put(PaidOrder paidOrder)
    {
        _paidOrderService.UpdatePaidOrder(paidOrder);        
        return CreatedAtAction(nameof(Get), new { id = paidOrder.PaidOrderId}, paidOrder);
    }
    
    [HttpDelete("{id}")]
    public ActionResult<PickUpPoint> Delete(int id)
    {
        var pickUpPoint = _paidOrderService.GetPaidOrderById(id);
        if (pickUpPoint == null)
        {
            return NotFound();
        }
        _paidOrderService.DeletePaidOrder(id);
        return Ok(pickUpPoint);
    } 
    
}