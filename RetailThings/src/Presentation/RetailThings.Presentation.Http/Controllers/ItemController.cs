// <copyright file="ItemController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Models.Item;

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
    public async Task<ActionResult<GetItemModel>> Get(int id)
    {
        var item = await _itemService.GetItemById(id);
        if (item is null)
        {
            return NotFound();
        }
        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult> Post(CreateItemModel createItem)
    {
        await _itemService.CreateItem(createItem);
        return Created();
    }

    
    [HttpPut]
    public async Task<ActionResult> Put(CreateItemModel createItem)
    {
        await _itemService.UpdateItem(createItem);
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<GetItemModel>> Delete(int id)
    {
        var pickUpPoint = await _itemService.GetItemById(id);
        if (pickUpPoint is null)
        {
            return NotFound();
        }
        _itemService.DeleteItem(id);
        return Ok(pickUpPoint);
    } 

    
    
}