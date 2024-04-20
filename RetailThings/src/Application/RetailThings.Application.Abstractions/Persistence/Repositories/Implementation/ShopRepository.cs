// <copyright file="ShopRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Contexts;
using RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

namespace RetailThings.Application.Contracts.Implementation;

public class ShopRepository : IShopRepository
{
    private ApplicationContext _applicationContext;
    private bool disposed = false;

    public ShopRepository(ApplicationContext applicationContext)
    {
        _applicationContext = _applicationContext;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _applicationContext.Dispose();
            }
        }
        this.disposed = true;
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public IEnumerable<Shop> GetShop()
    {
        return _applicationContext.Shops.ToList();
    }

    public Shop GetShopById(int shopId)
    {
        return _applicationContext.Shops.Find(shopId);
    }

    public void CreateShop(Shop shop)
    {
        _applicationContext.Shops.Add(shop);
    }

    public void DeleteShop(int shopId)
    {
        Shop shop = _applicationContext.Shops.Find(shopId);
        _applicationContext.Shops.Remove(shop);
    }

    public void UpdateShop(Shop shop)
    {
        _applicationContext.Entry(shop).State = EntityState.Modified;
    }

    public void Save()
    {
        _applicationContext.SaveChanges();
    }
}