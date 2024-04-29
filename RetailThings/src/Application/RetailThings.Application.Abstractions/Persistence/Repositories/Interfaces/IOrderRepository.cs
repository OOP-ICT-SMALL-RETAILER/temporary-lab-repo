// <copyright file="IOrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Entities;

namespace RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
#pragma warning disable

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetOrders();
    Task<Order?> GetOrderById(int orderId);
    Task CreateOrder(Order order);
    Task DeleteOrder(int orderId);
    Task UpdateOrder(Order order);
}