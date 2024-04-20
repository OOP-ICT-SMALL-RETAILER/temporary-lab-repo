// <copyright file="ItemInOrderService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Application.Contracts.Implementation;
#pragma warning disable

public class ItemInOrderService : IItemInOrderService
{
    private readonly ItemInOrderRepository _itemInOrderRepository;

    public ItemInOrderService(ItemInOrderRepository itemInOrderRepository)
    {
        _itemInOrderRepository = itemInOrderRepository;
    }

    public IEnumerable<ItemInOrder> GetItemsInOrders()
    {
        return _itemInOrderRepository.GetItemsInOrders();
    }

    public ItemInOrder GetItemInOrder(int itemInOrderId)
    {
        return _itemInOrderRepository.GetItemInOrder(itemInOrderId);
    }

    public void CreateItemInOrder(ItemInOrder itemInOrder)
    {
        _itemInOrderRepository.CreateItemInOrder(itemInOrder);
        _itemInOrderRepository.Save();
    }

    public void DeleteItemInOrder(int itemInOrderId)
    {
        _itemInOrderRepository.DeleteItemInOrder(itemInOrderId);
        _itemInOrderRepository.Save();

    }

    public void UpdateItemInOrder(ItemInOrder itemInOrder)
    {
        _itemInOrderRepository.UpdateItemInOrder(itemInOrder);
        _itemInOrderRepository.Save();
    }
    
}