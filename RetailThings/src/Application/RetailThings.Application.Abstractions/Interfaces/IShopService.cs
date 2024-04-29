// <copyright file="IShopService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Shop;

#pragma warning disable

namespace RetailThings.Application.Abstractions.Interfaces;

public interface IShopService
{
    Task<IEnumerable<Shop>> GetShop();
    Task<Shop?> GetShopById(int shopId);
    Task CreateShop(ShopModel shop);
    Task DeleteShop(int shopId);
    Task UpdateShop(Shop shop);
}