// <copyright file="IItemRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Entities;

#pragma warning disable

namespace RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;

public interface IItemRepository
{
    Task<IEnumerable<Item>> GetItems();
    Task<Item?> GetItemById(int itemId);
    Task CreateItem(Item item);
    Task DeleteItem(int itemId);
    Task UpdateItem(Item item);
}
