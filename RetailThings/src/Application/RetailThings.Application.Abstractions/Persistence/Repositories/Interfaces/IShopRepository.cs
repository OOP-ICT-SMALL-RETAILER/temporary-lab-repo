// <copyright file="IShopRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Entities;

#pragma warning disable

namespace RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;

public interface IShopRepository
{
    Task<IEnumerable<Shop>> GetShop();
    Task<Shop?> GetShopById(int shopId);
    Task CreateShop(Shop shop);
    Task DeleteShop(int shopId);
    Task UpdateShop(Shop shop);
}