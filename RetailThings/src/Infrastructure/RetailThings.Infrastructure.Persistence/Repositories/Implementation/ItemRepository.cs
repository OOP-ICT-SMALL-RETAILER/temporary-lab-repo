// <copyright file="ItemRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Infrastructure.Persistence.Contexts;

#pragma warning disable

namespace RetailThings.Infrastructure.Persistence.Repositories.Implementation;

public class ItemRepository : IItemRepository
{

    private readonly ApplicationContext _applicationContext;

    public ItemRepository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<IEnumerable<Item>> GetItems()
    {
        return await _applicationContext.Items
            .Include(x => x.Shop)
            .ToListAsync();
    }

    public async Task<Item?> GetItemById(int itemId)
    {
        return await _applicationContext.Items
            .Include(x => x.Shop)
            .FirstOrDefaultAsync(x => x.ItemId == itemId);
    }

    public async Task CreateItem(Item item)
    {
        await _applicationContext.Items.AddAsync(item);
        
        await _applicationContext.SaveChangesAsync();
    }

    public async Task DeleteItem(int itemId)
    {
        Item item = await _applicationContext.Items.FindAsync(itemId);
        _applicationContext.Items.Remove(item);
        
        await _applicationContext.SaveChangesAsync();
    }

    public async Task UpdateItem(Item item)
    {
        _applicationContext.Entry(item).State = EntityState.Modified;

        await _applicationContext.SaveChangesAsync();
    }
}
