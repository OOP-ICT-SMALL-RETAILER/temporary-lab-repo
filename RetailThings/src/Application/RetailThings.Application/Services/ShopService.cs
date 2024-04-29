// <copyright file="ShopService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Shop;

#pragma warning disable

namespace RetailThings.Application.Services;

public class ShopService : IShopService
{
    private readonly IShopRepository _shopRepository;
    
    public ShopService(IShopRepository shopRepository)
    {
        _shopRepository = shopRepository;
    }

    public async Task<IEnumerable<Shop>> GetShop()
    {
        return await _shopRepository.GetShop();
    }

    public async Task<Shop> GetShopById(int shopId)
    {
        return await _shopRepository.GetShopById(shopId);
    }

    public async Task CreateShop(ShopModel shop)
    {
        await _shopRepository.CreateShop(new Shop()
        {
            Email = shop.Email,
            Password = shop.Password,
            Title = shop.Title,
            Owner = shop.Owner,
        });
    }

    public async Task DeleteShop(int shopId)
    {
        await _shopRepository.DeleteShop(shopId);
    }

    public async Task UpdateShop(Shop shop)
    {
        await _shopRepository.UpdateShop(shop);
    }
}