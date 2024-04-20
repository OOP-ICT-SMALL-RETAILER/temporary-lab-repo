// <copyright file="IItemService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Infrastructure.Persistence.Entities;

#pragma warning disable

namespace RetailThings.Application.Contracts.Interfaces;

public interface IItemService
{
    IEnumerable<Item> GetItems();
    Item GetItemById(int itemId);
    void CreateItem(Item item);
    void DeleteItem(int itemId);
    void UpdateItem(Item item);
}