// <copyright file="PickUpPointPointRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Infrastructure.Persistence.Contexts;

#pragma warning disable

namespace RetailThings.Infrastructure.Persistence.Repositories.Implementation;

public class PickUpPointPointRepository : IPickUpPointRepository
{
    private readonly ApplicationContext _applicationContext;

    public PickUpPointPointRepository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<IEnumerable<PickUpPoint>> GetPickUpPoints()
    {
        return await _applicationContext.PickUpPoints
            .ToListAsync();
    }

    public async Task<PickUpPoint?> GetPickUpPointById(int pickUpPointId)
    {
        return await _applicationContext.PickUpPoints.FindAsync(pickUpPointId);
    }

    public async Task CreatePickUpPoint(PickUpPoint pickUpPoint)
    {
        await _applicationContext.PickUpPoints.AddAsync(pickUpPoint);
        
        await _applicationContext.SaveChangesAsync();
    }

    public async Task DeletePickUpPoint(int pickUpPointId)
    {
        PickUpPoint? pickUpPoint = await _applicationContext.PickUpPoints.FindAsync(pickUpPointId);
        _applicationContext.PickUpPoints.Remove(pickUpPoint);

        await _applicationContext.SaveChangesAsync();
    }

    public async Task UpdatePickUpPoint(PickUpPoint pickUpPoint)
    {
        _applicationContext.Entry(pickUpPoint).State = EntityState.Modified;
        
        await _applicationContext.SaveChangesAsync();
    }
}
