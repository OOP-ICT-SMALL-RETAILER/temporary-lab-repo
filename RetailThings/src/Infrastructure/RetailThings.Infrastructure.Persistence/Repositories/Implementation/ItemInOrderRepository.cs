// <copyright file="ItemInOrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Infrastructure.Persistence.Contexts;

namespace RetailThings.Infrastructure.Persistence.Repositories.Implementation;
#pragma warning disable

public class ItemInOrderRepository : IItemInOrderRepository
{
    private readonly ApplicationContext _applicationContext;

    public ItemInOrderRepository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<IEnumerable<ItemInOrder>> GetItemsInOrders()
    {
        return await _applicationContext.ItemInOrders
            .Include(x => x.Item)
            .ThenInclude(x => x.Shop)
            .ToListAsync();
    }

    public async Task<ItemInOrder?> GetItemInOrder(int itemInOrderId)
    {
        return await _applicationContext.ItemInOrders
            .Include(x => x.Item)
            .ThenInclude(x => x.Shop)
            .FirstOrDefaultAsync(x => x.ItemInOrderId == itemInOrderId);
    }

    public async Task CreateItemInOrder(ItemInOrder itemInOrder)
    {
        await _applicationContext.ItemInOrders.AddAsync(itemInOrder);

        await _applicationContext.SaveChangesAsync();
    }

    public async Task DeleteItemInOrder(int itemInOrderId)
    {
        ItemInOrder itemInOrder = await _applicationContext.ItemInOrders.FindAsync(itemInOrderId);
        _applicationContext.ItemInOrders.Remove(itemInOrder);

        await _applicationContext.SaveChangesAsync();
    }

    public async Task UpdateItemInOrder(ItemInOrder itemInOrder)
    {
        _applicationContext.ItemInOrders.Update(itemInOrder);

        await _applicationContext.SaveChangesAsync();
    }
}
