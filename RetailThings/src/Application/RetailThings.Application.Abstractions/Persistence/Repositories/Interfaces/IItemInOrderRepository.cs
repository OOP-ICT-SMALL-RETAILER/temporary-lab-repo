// <copyright file="IItemInOrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Entities;

namespace RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
#pragma warning disable

public interface IItemInOrderRepository
{
    Task<IEnumerable<ItemInOrder>> GetItemsInOrders();
    Task<ItemInOrder?> GetItemInOrder(int itemInOrderId);
    Task CreateItemInOrder(ItemInOrder temInOrder);
    Task DeleteItemInOrder(int itemInOrderId);
    Task UpdateItemInOrder(ItemInOrder temInOrder);
}
