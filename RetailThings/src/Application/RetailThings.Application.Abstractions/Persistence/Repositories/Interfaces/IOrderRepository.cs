// <copyright file="IOrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Application.Contracts.Interfaces;
#pragma warning disable

public interface IOrderRepository : IDisposable
{
    IEnumerable<Order> GetOrders();
    Order GetOrderById(int orderId);
    void CreateOrder(Order order);
    void DeleteOrder(int orderId);
    void UpdateOrder(Order order);
    void Save();
}