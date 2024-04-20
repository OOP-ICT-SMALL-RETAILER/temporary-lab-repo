// <copyright file="OrderService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

namespace RetailThings.Application.Contracts.Implementation;

public class OrderService : IOrderService
{

    private IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public IEnumerable<Order> GetOrders()
    {
        return _orderRepository.GetOrders();
    }

    public Order GetOrderById(int orderId)
    {
        return _orderRepository.GetOrderById(orderId);
    }

    public void CreateOrder(Order order)
    { 
        _orderRepository.CreateOrder(order);
        _orderRepository.Save();
    }

    public void DeleteOrder(int orderId)
    {
        _orderRepository.DeleteOrder(orderId);
        _orderRepository.Save();
    }

    public void UpdateOrder(Order order)
    {
        _orderRepository.UpdateOrder(order);
        _orderRepository.Save();
    }
}