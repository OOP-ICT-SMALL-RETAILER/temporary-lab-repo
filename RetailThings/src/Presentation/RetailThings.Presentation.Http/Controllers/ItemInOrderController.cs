// <copyright file="ItemInOrderController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.ItemInOrder;

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
    public async Task<ActionResult<ItemInOrder>> Get(int id)
    {
        var itemInOrder = await _itemInOrderService.GetItemInOrder(id);
        if (itemInOrder is null)
        {
            return NotFound();
        }
        return Ok(itemInOrder);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreateItemInOrderModel itemInOrder)
    {
        await _itemInOrderService.CreateItemInOrder(itemInOrder);
        return Ok();
    }

    
    [HttpPut]
    public async Task<ActionResult<ItemInOrder>> Put(CreateItemInOrderModel itemInOrder)
    {
        await _itemInOrderService.UpdateItemInOrder(itemInOrder);
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<ItemInOrder>> Delete(int id)
    {
        var pickUpPoint = await _itemInOrderService.GetItemInOrder(id);
        if (pickUpPoint is null)
        {
            return NotFound();
        }
        await _itemInOrderService.DeleteItemInOrder(id);
        return Ok(pickUpPoint);
    } 

    

}