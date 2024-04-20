// <copyright file="ItemController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    private readonly IItemService _itemService;

    public ItemController(IItemService itemService)
    {
        _itemService = itemService;
    }
    
    [HttpGet("{id}")]
    public ActionResult<Item> Get(int id)
    {
        var item = _itemService.GetItemById(id);
        if (item == null)
        {
            return NotFound();
        }
        return Ok(item);
    }

    [HttpPost]
    public ActionResult<Item> Post(Item item)
    {
        _itemService.CreateItem(item);
        return CreatedAtAction(nameof(Get), new { id = item.ItemId}, item);
    }

    
    [HttpPut]
    public ActionResult<Item> Put(Item item)
    {
        _itemService.UpdateItem(item);        
        return CreatedAtAction(nameof(Get), new { id = item.ItemId}, item);
    }
    
    [HttpDelete("{id}")]
    public ActionResult<Item> Delete(int id)
    {
        var pickUpPoint = _itemService.GetItemById(id);
        if (pickUpPoint == null)
        {
            return NotFound();
        }
        _itemService.DeleteItem(id);
        return Ok(pickUpPoint);
    } 

    
    
}