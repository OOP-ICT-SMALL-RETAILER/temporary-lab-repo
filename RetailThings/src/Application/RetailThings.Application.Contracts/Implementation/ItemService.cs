// <copyright file="ItemService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

namespace RetailThings.Application.Contracts.Implementation;

public class ItemService : IItemService
{
    
    private IItemRepository _itemRepository;

    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public IEnumerable<Item> GetItems()
    {
        return _itemRepository.GetItems();
    }

    public Item GetItemById(int itemId)
    {
        return _itemRepository.GetItemById(itemId);
    }

    public void CreateItem(Item item)
    {
        _itemRepository.CreateItem(item);
        _itemRepository.Save();
    }

    public void DeleteItem(int itemId)
    {
        _itemRepository.DeleteItem(itemId);
        _itemRepository.Save();
    }

    public void UpdateItem(Item item)
    {
        _itemRepository.UpdateItem(item);
        _itemRepository.Save();
    }
    
}