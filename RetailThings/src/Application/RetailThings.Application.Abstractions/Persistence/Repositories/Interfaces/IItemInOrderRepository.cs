// <copyright file="IItemInOrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Application.Contracts.Interfaces;
#pragma warning disable

public interface IItemInOrderRepository : IDisposable
{
    IEnumerable<ItemInOrder> GetItemsInOrders();
    ItemInOrder GetItemInOrder(int itemInOrderId);
    void CreateItemInOrder(ItemInOrder temInOrder);
    void DeleteItemInOrder(int itemInOrderId);
    void UpdateItemInOrder(ItemInOrder temInOrder);
    void Save();
}