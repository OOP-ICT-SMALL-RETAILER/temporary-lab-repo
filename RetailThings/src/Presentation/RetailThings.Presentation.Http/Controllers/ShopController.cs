// <copyright file="ShopController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Presentation.Http.Controllers;
#pragma warning disable

[ApiController]
[Route("[controller]")]
public class ShopController : ControllerBase
{
    private readonly IShopService _shopService;

    public ShopController(IShopService shopService)
    {
        _shopService = shopService;
    }
    
    [HttpGet("{id}")]
    public ActionResult<Shop> Get(int id)
    {
        var shop = _shopService.GetShopById(id);
        if (shop == null)
        {
            return NotFound();
        }
        return Ok(shop);
    }

    [HttpPost]
    public ActionResult<Shop> Post(Shop shop)
    {
        _shopService.CreateShop(shop);
        return CreatedAtAction(nameof(Get), new { id = shop.ShopId }, shop);
    }

    
    [HttpPut]
    public ActionResult<Shop> Put(Shop shop)
    {
        _shopService.UpdateShop(shop);
        return CreatedAtAction(nameof(Get), new { id = shop.ShopId }, shop);
    }
    
    [HttpDelete("{id}")]
    public ActionResult<Shop> Delete(int id)
    {
        var shop = _shopService.GetShopById(id);
        if (shop == null)
        {
            return NotFound();
        }
        _shopService.DeleteShop(id);
        return Ok(shop);
    }
}