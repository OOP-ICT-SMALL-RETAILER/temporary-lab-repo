// <copyright file="ItemInOrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Contexts;
using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Application.Contracts.Implementation;
#pragma warning disable

public class ItemInOrderRepository : IItemInOrderRepository
{
    private ApplicationContext _applicationContext;
    private bool disposed = false;

    public ItemInOrderRepository(ApplicationContext applicationContext)
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

    public IEnumerable<ItemInOrder> GetItemsInOrders()
    {
        return _applicationContext.ItemInOrders.ToList();
    }

    public ItemInOrder GetItemInOrder(int itemInOrderId)
    {
        return _applicationContext.ItemInOrders.Find(itemInOrderId);
    }

    public void CreateItemInOrder(ItemInOrder itemInOrder)
    {
        _applicationContext.ItemInOrders.Add(itemInOrder);
    }

    public void DeleteItemInOrder(int itemInOrderId)
    {
        ItemInOrder itemInOrder = _applicationContext.ItemInOrders.Find(itemInOrderId);
        _applicationContext.ItemInOrders.Remove(itemInOrder);
    }

    public void UpdateItemInOrder(ItemInOrder itemInOrder)
    {
        _applicationContext.ItemInOrders.Update(itemInOrder);
    }

    public void Save()
    {
        _applicationContext.SaveChanges();
    }
}