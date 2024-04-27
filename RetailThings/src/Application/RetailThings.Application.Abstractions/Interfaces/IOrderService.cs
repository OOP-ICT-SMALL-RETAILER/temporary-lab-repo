// <copyright file="IOrderService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Order;

namespace RetailThings.Application.Abstractions.Interfaces;
#pragma warning disable

public interface IOrderService
{
    Task<IEnumerable<GetOrderModel>> GetOrders();
    Task<GetOrderModel?> GetOrderById(int orderId);
    Task CreateOrder(CreateOrderModel order);
    Task DeleteOrder(int orderId);
    Task UpdateOrder(CreateOrderModel order);
}