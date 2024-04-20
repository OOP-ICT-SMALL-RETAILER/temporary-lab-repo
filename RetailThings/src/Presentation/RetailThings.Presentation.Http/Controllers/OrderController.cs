// <copyright file="OrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;

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
    public ActionResult<Order> Get(int id)
    {
        var order = _orderService.GetOrderById(id);
        if (order == null)
        {
            return NotFound();
        }
        return Ok(order);
    }

    [HttpPost]
    public ActionResult<Order> Post(Order order)
    {
        _orderService.CreateOrder(order);
        return CreatedAtAction(nameof(Get), new { id = order.OrderId}, order);
    }

    
    [HttpPut]
    public ActionResult<Order> Put(Order order)
    {
        _orderService.UpdateOrder(order);        
        return CreatedAtAction(nameof(Get), new { id = order.OrderId}, order);
    }
    
    [HttpDelete("{id}")]
    public ActionResult<Order> Delete(int id)
    {
        var order = _orderService.GetOrderById(id);
        if (order == null)
        {
            return NotFound();
        }
        _orderService.DeleteOrder(id);
        return Ok(order);
    } 
    
}