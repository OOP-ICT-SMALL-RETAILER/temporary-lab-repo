// <copyright file="ShopRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Infrastructure.Persistence.Contexts;

#pragma warning disable

namespace RetailThings.Infrastructure.Persistence.Repositories.Implementation;

public class ShopRepository : IShopRepository
{
    private readonly ApplicationContext _applicationContext;
    
    public ShopRepository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<IEnumerable<Shop>> GetShop()
    {
        return await _applicationContext.Shops.ToListAsync();
    }

    public async Task<Shop?> GetShopById(int shopId)
    {
        return await _applicationContext.Shops.FindAsync(shopId);
    }

    public async Task CreateShop(Shop shop)
    {
        await _applicationContext.Shops.AddAsync(shop);

        await _applicationContext.SaveChangesAsync();
    }

    public async Task DeleteShop(int shopId)
    {
        Shop shop = await _applicationContext.Shops.FindAsync(shopId);
        _applicationContext.Shops.Remove(shop);
        
        await _applicationContext.SaveChangesAsync();
    }

    public async Task UpdateShop(Shop shop)
    {
        _applicationContext.Entry(shop).State = EntityState.Modified;
        
        await _applicationContext.SaveChangesAsync();
    }
}