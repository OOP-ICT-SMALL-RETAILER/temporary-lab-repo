// <copyright file="IItemInOrderService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.ItemInOrder;

namespace RetailThings.Application.Abstractions.Interfaces;
#pragma warning disable

public interface IItemInOrderService
{
    Task<IEnumerable<GetItemInOrderModel>> GetItemsInOrders();
    Task<GetItemInOrderModel?> GetItemInOrder(int itemInOrderId);
    Task CreateItemInOrder(CreateItemInOrderModel temInOrder);
    Task DeleteItemInOrder(int itemInOrderId);
    Task UpdateItemInOrder(CreateItemInOrderModel temInOrder);
}