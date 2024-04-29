// <copyright file="PaidOrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Infrastructure.Persistence.Contexts;

#pragma warning disable

namespace RetailThings.Infrastructure.Persistence.Repositories.Implementation;

public class PaidOrderRepository : IPaidOrderRepository
{
    private readonly ApplicationContext _applicationContext;
    
    public PaidOrderRepository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<IEnumerable<PaidOrder>> GetPaidOrders()
    {
        return await _applicationContext.PaidOrders
            .Include(x => x.Order)
            .ThenInclude(x => x.User)
            .Include(x => x.Order)
            .ThenInclude(x => x.PickUpPoint)
            .Include(x => x.Order)
            .ThenInclude(x => x.ItemInOrders)
            .ToListAsync();
    }

    public async Task<PaidOrder?> GetPaidOrderById(int paidOrderId)
    {
        return await _applicationContext.PaidOrders
            .Include(x => x.Order)
            .ThenInclude(x => x.User)
            .Include(x => x.Order)
            .ThenInclude(x => x.PickUpPoint)
            .Include(x => x.Order)
            .ThenInclude(x => x.ItemInOrders)
            .FirstOrDefaultAsync(x => x.PaidOrderId == paidOrderId);
    }

    public async Task CreatePaidOrder(PaidOrder paidOrder)
    {
        _applicationContext.PaidOrders.Add(paidOrder);
        
        await _applicationContext.SaveChangesAsync();
    }

    public async Task DeletePaidOrder(int paidOrderId)
    {
        PaidOrder paidOrder = _applicationContext.PaidOrders.Find(paidOrderId);
        _applicationContext.PaidOrders.Remove(paidOrder);
        
        await _applicationContext.SaveChangesAsync();
    }

    public async Task UpdatePaidOrder(PaidOrder paidOrder)
    {
        _applicationContext.Entry(paidOrder).State = EntityState.Modified;

        await _applicationContext.SaveChangesAsync();
    }
}