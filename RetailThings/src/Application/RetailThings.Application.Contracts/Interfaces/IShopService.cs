// <copyright file="IShopService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

namespace RetailThings.Application.Contracts.Interfaces;

public interface IShopService
{
    IEnumerable<Shop> GetShop();
    Shop GetShopById(int shopId);
    void CreateShop(Shop shop);
    void DeleteShop(int shopId);
    void UpdateShop(Shop shop);
}