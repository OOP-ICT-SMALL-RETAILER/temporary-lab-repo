// <copyright file="ItemService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Item;

#pragma warning disable

namespace RetailThings.Application.Services;

public class ItemService : IItemService
{

    private readonly IItemRepository _itemRepository;

    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public async Task<IEnumerable<GetItemModel>> GetItems()
    {
        return (await _itemRepository.GetItems())
            .Select(x => new GetItemModel
            {
                ItemId = x.ItemId,
                Shop = x.Shop,
                FullPrice = x.FullPrice,
                CurrentPrice = x.CurrentPrice,
                Title = x.Title,
                Description = x.Description,
                Rating = x.Rating,
                CountOfRatings = x.CountOfRatings,
                Category = x.Category,
                IsSale = x.IsSale,
            });
    }

    public async Task<GetItemModel?> GetItemById(int itemId)
    {
        var result =  await _itemRepository.GetItemById(itemId);

        if (result is null)
            return null;

        return new GetItemModel
        {
            ItemId = result.ItemId,
            Shop = result.Shop,
            FullPrice = result.FullPrice,
            CurrentPrice = result.CurrentPrice,
            Title = result.Title,
            Description = result.Description,
            Rating = result.Rating,
            CountOfRatings = result.CountOfRatings,
            Category = result.Category,
            IsSale = result.IsSale,
        };
    }

    public async Task CreateItem(CreateItemModel createItem)
    {
        await _itemRepository.CreateItem(new Item()
        {
            ShopId = createItem.ShopId,
            FullPrice = createItem.FullPrice,
            CurrentPrice = createItem.CurrentPrice,
            Title = createItem.Title,
            Description = createItem.Description,
            Rating = createItem.Rating,
            CountOfRatings = createItem.CountOfRatings,
            Category = createItem.Category,
            IsSale = createItem.IsSale,
        });
    }

    public async Task DeleteItem(int itemId)
    {
        await _itemRepository.DeleteItem(itemId);
    }

    public async Task UpdateItem(CreateItemModel createItem)
    {
        await _itemRepository.UpdateItem(new Item()
        {
            ShopId = createItem.ShopId,
            FullPrice = createItem.FullPrice,
            CurrentPrice = createItem.CurrentPrice,
            Title = createItem.Title,
            Description = createItem.Description,
            Rating = createItem.Rating,
            CountOfRatings = createItem.CountOfRatings,
            Category = createItem.Category,
            IsSale = createItem.IsSale,
        });
    }

}
