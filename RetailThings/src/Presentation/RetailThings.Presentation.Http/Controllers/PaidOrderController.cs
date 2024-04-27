// <copyright file="PaidOrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.PaidOrder;

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
    public async Task<ActionResult<PaidOrder>> Get(int id)
    {
        var paidOrder = await _paidOrderService.GetPaidOrderById(id);
        if (paidOrder is null)
        {
            return NotFound();
        }
        return Ok(paidOrder);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreatePaidOrderModel paidOrder)
    {
        await _paidOrderService.CreatePaidOrder(paidOrder);
        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult> Put(CreatePaidOrderModel paidOrder)
    {
        await _paidOrderService.UpdatePaidOrder(paidOrder);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<PickUpPoint>> Delete(int id)
    {
        var pickUpPoint = await _paidOrderService.GetPaidOrderById(id);
        if (pickUpPoint is null)
        {
            return NotFound();
        }
        await _paidOrderService.DeletePaidOrder(id);
        return Ok(pickUpPoint);
    } 
    
}