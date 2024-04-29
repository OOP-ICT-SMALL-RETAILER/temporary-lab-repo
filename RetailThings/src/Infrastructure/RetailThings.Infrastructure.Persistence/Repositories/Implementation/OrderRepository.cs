// <copyright file="OrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Infrastructure.Persistence.Contexts;

#pragma warning disable

namespace RetailThings.Infrastructure.Persistence.Repositories.Implementation;

public class OrderRepository : IOrderRepository
{
    private readonly ApplicationContext _applicationContext;

    public OrderRepository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<IEnumerable<Order>> GetOrders()
    {
        return await _applicationContext.Orders
            .Include(x => x.User)
            .Include(x => x.PickUpPoint)
            .Include(x => x.ItemInOrders)
            .ThenInclude(x => x.Item)
            .ToListAsync();
    }

    public async Task<Order?> GetOrderById(int orderId)
    {
        return await _applicationContext.Orders
            .Include(x => x.User)
            .Include(x => x.PickUpPoint)
            .Include(x => x.ItemInOrders)
            .ThenInclude(x => x.Item)
            .FirstOrDefaultAsync(x => x.OrderId == orderId);
    }

    public async Task CreateOrder(Order order)
    {
        _applicationContext.Orders.AddAsync(order);

        await _applicationContext.SaveChangesAsync();
    }

    public async Task DeleteOrder(int orderId)
    {
        Order? order = await _applicationContext.Orders.FindAsync(orderId);
        _applicationContext.Orders.Remove(order);

        await _applicationContext.SaveChangesAsync();
    }

    public async Task UpdateOrder(Order order)
    {
        _applicationContext.Entry(order).State = EntityState.Modified;

        await _applicationContext.SaveChangesAsync();
    }
}
