// <copyright file="OrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Contexts;
using RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

namespace RetailThings.Application.Contracts.Implementation;

public class OrderRepository : IOrderRepository
{
    private ApplicationContext _applicationContext;
    private bool disposed = false;

    public OrderRepository(ApplicationContext applicationContext)
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

    public IEnumerable<Order> GetOrders()
    {
        return _applicationContext.Orders.ToList();
    }

    public Order GetOrderById(int orderId)
    {
        return _applicationContext.Orders.Find(orderId);
    }

    public void CreateOrder(Order order)
    { 
        _applicationContext.Orders.Add(order);
    }

    public void DeleteOrder(int orderId)
    {
        Order order = _applicationContext.Orders.Find(orderId);
        _applicationContext.Orders.Remove(order);
    }

    public void UpdateOrder(Order order)
    {
        _applicationContext.Entry(order).State = EntityState.Modified;
    }

    public void Save()
    {
        _applicationContext.SaveChanges();
    }
}