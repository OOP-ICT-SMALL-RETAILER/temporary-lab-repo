// <copyright file="OrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Order;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Order>> Get(int id)
    {
        var order = await _orderService.GetOrderById(id);
        if (order is null)
        {
            return NotFound();
        }
        return Ok(order);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreateOrderModel order)
    {
        await _orderService.CreateOrder(order);
        return Ok();
    }

    
    [HttpPut]
    public async Task<ActionResult> Put(CreateOrderModel order)
    {
        await _orderService.UpdateOrder(order);        
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<Order>> Delete(int id)
    {
        var order = await _orderService.GetOrderById(id);
        if (order is null)
        {
            return NotFound();
        }
        await _orderService.DeleteOrder(id);
        return Ok(order);
    } 
    
}