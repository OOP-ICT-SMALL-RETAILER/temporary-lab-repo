// <copyright file="OrderService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.ItemInOrder;
using RetailThings.Application.Models.Order;

#pragma warning disable

namespace RetailThings.Application.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<IEnumerable<GetOrderModel>> GetOrders()
    {
        return (await _orderRepository.GetOrders())
            .Select(result => new GetOrderModel()
            {
                OrderId = result.OrderId,
                User = result.User,
                PickUpPoint = result.PickUpPoint,
                Status = result.Status,
                ItemInOrders = result.ItemInOrders
                    .Select(y => new GetItemInOrderModel()
                    {
                        Item = y.Item,
                        OrderId = y.OrderId,
                        Count = y.Count,
                        Price = y.Price,
                    })
                    .ToList()

            });
    }

    public async Task<GetOrderModel?> GetOrderById(int orderId)
    {
        var result = await _orderRepository.GetOrderById(orderId);

        if (result is null)
            return null;

        return new GetOrderModel()
        {
            OrderId = result.OrderId,
            User = result.User,
            PickUpPoint = result.PickUpPoint,
            Status = result.Status,
            ItemInOrders = result.ItemInOrders
                .Select(y => new GetItemInOrderModel()
                {
                    Item = y.Item,
                    OrderId = y.OrderId,
                    Count = y.Count,
                    Price = y.Price,
                })
                .ToList()

        };
    }

    public async Task CreateOrder(CreateOrderModel order)
    {
        await _orderRepository.CreateOrder(new Order()
        {
            UserId = order.UserId,
            PickUpPointId = order.PickUpPointId,
            Status = order.Status,
        });
    }

    public async Task DeleteOrder(int orderId)
    {
        await _orderRepository.DeleteOrder(orderId);
    }

    public async Task UpdateOrder(CreateOrderModel order)
    {
        await _orderRepository.UpdateOrder(new Order()
        {
            UserId = order.UserId,
            PickUpPointId = order.PickUpPointId,
            Status = order.Status,
        });
    }
}
