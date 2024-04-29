// <copyright file="ItemInOrderService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.ItemInOrder;

namespace RetailThings.Application.Services;
#pragma warning disable

public class ItemInOrderService : IItemInOrderService
{
    private readonly IItemInOrderRepository _itemInOrderRepository;

    public ItemInOrderService(IItemInOrderRepository itemInOrderRepository)
    {
        _itemInOrderRepository = itemInOrderRepository;
    }

    public async Task<IEnumerable<GetItemInOrderModel>> GetItemsInOrders()
    {
        return (await _itemInOrderRepository.GetItemsInOrders())
            .Select(result => new GetItemInOrderModel()
            {
                Item = result.Item,
                OrderId = result.OrderId,
                Count = result.Count,
                Price = result.Price,
            });
    }

    public async Task<GetItemInOrderModel?> GetItemInOrder(int itemInOrderId)
    {
        var result = await _itemInOrderRepository.GetItemInOrder(itemInOrderId);

        if (result is null)
            return null;

        return new GetItemInOrderModel()
        {
            Item = result.Item,
            OrderId = result.OrderId,
            Count = result.Count,
            Price = result.Price,
        };
    }

    public async Task CreateItemInOrder(CreateItemInOrderModel itemInOrder)
    {
        await _itemInOrderRepository.CreateItemInOrder(new ItemInOrder()
        {
            OrderId = itemInOrder.OrderId,
            ItemId = itemInOrder.ItemId,
            Count = itemInOrder.Count,
            Price = itemInOrder.Price,
        });
    }

    public async Task DeleteItemInOrder(int itemInOrderId)
    {
        await _itemInOrderRepository.DeleteItemInOrder(itemInOrderId);

    }

    public async Task UpdateItemInOrder(CreateItemInOrderModel itemInOrder)
    {
        await _itemInOrderRepository.UpdateItemInOrder(new ItemInOrder()
        {
            OrderId = itemInOrder.OrderId,
            ItemId = itemInOrder.ItemId,
            Count = itemInOrder.Count,
            Price = itemInOrder.Price,
        });
    }

}
