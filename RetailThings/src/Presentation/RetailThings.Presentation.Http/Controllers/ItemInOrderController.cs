// <copyright file="ItemInOrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class ItemInOrderController : ControllerBase
{
    private readonly IItemInOrderService _itemInOrderService;

    public ItemInOrderController(IItemInOrderService itemInOrderService)
    {
        _itemInOrderService = itemInOrderService;
    }
    
    [HttpGet("{id}")]
    public ActionResult<ItemInOrder> Get(int id)
    {
        var itemInOrder = _itemInOrderService.GetItemInOrder(id);
        if (itemInOrder == null)
        {
            return NotFound();
        }
        return Ok(itemInOrder);
    }

    [HttpPost]
    public ActionResult<ItemInOrder> Post(ItemInOrder itemInOrder)
    {
        _itemInOrderService.CreateItemInOrder(itemInOrder);
        return CreatedAtAction(nameof(Get), new { id = itemInOrder.ItemInOrderId}, itemInOrder);
    }

    
    [HttpPut]
    public ActionResult<ItemInOrder> Put(ItemInOrder itemInOrder)
    {
        _itemInOrderService.UpdateItemInOrder(itemInOrder);        
        return CreatedAtAction(nameof(Get), new { id = itemInOrder.ItemInOrderId}, itemInOrder);
    }
    
    [HttpDelete("{id}")]
    public ActionResult<ItemInOrder> Delete(int id)
    {
        var pickUpPoint = _itemInOrderService.GetItemInOrder(id);
        if (pickUpPoint == null)
        {
            return NotFound();
        }
        _itemInOrderService.DeleteItemInOrder(id);
        return Ok(pickUpPoint);
    } 

    

}