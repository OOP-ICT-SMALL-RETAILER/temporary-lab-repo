// <copyright file="IItemService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Item;

#pragma warning disable

namespace RetailThings.Application.Abstractions.Interfaces;

public interface IItemService
{
    Task<IEnumerable<GetItemModel>> GetItems();
    Task<GetItemModel?> GetItemById(int itemId);
    Task CreateItem(CreateItemModel createItem);
    Task DeleteItem(int itemId);
    Task UpdateItem(CreateItemModel createItem);
}