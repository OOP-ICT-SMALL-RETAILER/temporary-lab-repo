// <copyright file="PaidOrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Contexts;
using RetailThings.Infrastructure.Persistence.Entities;
#pragma warning disable

namespace RetailThings.Application.Contracts.Implementation;

public class PaidOrderRepository : IPaidOrderRepository
{
    private ApplicationContext _applicationContext;
    private bool disposed = false;

    public PaidOrderRepository(ApplicationContext applicationContext)
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

    public IEnumerable<PaidOrder> GetPaidOrders()
    {
        return _applicationContext.PaidOrders.ToList();
    }

    public PaidOrder GetPaidOrderById(int paidOrderId)
    {
        return _applicationContext.PaidOrders.Find(paidOrderId);
    }

    public void CreatePaidOrder(PaidOrder paidOrder)
    {
        _applicationContext.PaidOrders.Add(paidOrder);
    }

    public void DeletePaidOrder(int paidOrderId)
    {
        PaidOrder paidOrder = _applicationContext.PaidOrders.Find(paidOrderId);
        _applicationContext.PaidOrders.Remove(paidOrder);
    }

    public void UpdatePaidOrder(PaidOrder paidOrder)
    {
        _applicationContext.Entry(paidOrder).State = EntityState.Modified;
    }

    public void Save()
    {
        _applicationContext.SaveChanges();
    }
}