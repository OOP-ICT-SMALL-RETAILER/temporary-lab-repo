// <copyright file="ShopController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Shop;

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
    public async Task<ActionResult<Shop>> Get(int id)
    {
        var shop = await _shopService.GetShopById(id);
        if (shop is null)
        {
            return NotFound();
        }
        return Ok(shop);
    }

    [HttpPost]
    public async Task<ActionResult> Post(ShopModel shop)
    {
        await _shopService.CreateShop(shop);
        return Ok();
    }


    [HttpPut]
    public async Task<ActionResult> Put(Shop shop)
    {
        await _shopService.UpdateShop(shop);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Shop>> Delete(int id)
    {
        var shop = await _shopService.GetShopById(id);
        if (shop is null)
        {
            return NotFound();
        }
        await _shopService.DeleteShop(id);
        return Ok(shop);
    }
}
