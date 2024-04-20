// <copyright file="ItemRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Contexts;
using RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

namespace RetailThings.Application.Contracts.Implementation;

public class ItemRepository : IItemRepository
{
    
    private ApplicationContext _applicationContext;
    private bool disposed = false;

    public ItemRepository(ApplicationContext applicationContext)
    {
        _applicationContext = _applicationContext;
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _applicationContext.Dispose();
            }
        }
        disposed = true;
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public IEnumerable<Item> GetItems()
    {
        return _applicationContext.Items.ToList();
    }

    public Item GetItemById(int itemId)
    {
        return _applicationContext.Items.Find(itemId);
    }

    public void CreateItem(Item item)
    {
        _applicationContext.Items.Add(item);
    }

    public void DeleteItem(int itemId)
    {
        Item item = _applicationContext.Items.Find(itemId);
        _applicationContext.Items.Remove(item);
    }

    public void UpdateItem(Item item)
    {
        _applicationContext.Entry(item).State = EntityState.Modified;
    }

    public void Save()
    {
        _applicationContext.SaveChanges();
    }
}