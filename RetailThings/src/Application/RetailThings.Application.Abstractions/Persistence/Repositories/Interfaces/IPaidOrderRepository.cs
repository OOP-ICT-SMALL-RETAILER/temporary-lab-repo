// <copyright file="IPaidOrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Application.Contracts.Interfaces;
#pragma warning disable

public interface IPaidOrderRepository : IDisposable
{
    IEnumerable<PaidOrder> GetPaidOrders();
    PaidOrder GetPaidOrderById(int paidOrderId);
    void CreatePaidOrder(PaidOrder paidOrder);
    void DeletePaidOrder(int paidOrderId);
    void UpdatePaidOrder(PaidOrder paidOrder);
    void Save();
    
}