// <copyright file="PickUpPointPointRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Contexts;
using RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

namespace RetailThings.Application.Contracts.Implementation;

public class PickUpPointPointRepository : IPickUpPointRepository
{
    private ApplicationContext _applicationContext;
    private bool disposed = false;

    public PickUpPointPointRepository(ApplicationContext applicationContext)
    {
        _applicationContext = _applicationContext;
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _applicationContext.Dispose();
            }
        }
        disposed = true;
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public IEnumerable<PickUpPoint> GetPickUpPoints()
    {
        return _applicationContext.PickUpPoints.ToList();
    }

    public PickUpPoint GetPickUpPointById(int pickUpPointId)
    {
        return _applicationContext.PickUpPoints.Find(pickUpPointId);
    }

    public void CreatePickUpPoint(PickUpPoint pickUpPoint)
    {
        _applicationContext.PickUpPoints.Add(pickUpPoint);
    }

    public void DeletePickUpPoint(int pickUpPointId)
    {
        PickUpPoint pickUpPoint = _applicationContext.PickUpPoints.Find(pickUpPointId);
        _applicationContext.PickUpPoints.Remove(pickUpPoint);
    }

    public void UpdatePickUpPoint(PickUpPoint pickUpPoint)
    {
        _applicationContext.Entry(pickUpPoint).State = EntityState.Modified;
    }

    public void Save()
    {
        _applicationContext.SaveChanges();
    }
}