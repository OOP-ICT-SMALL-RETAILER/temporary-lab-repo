// <copyright file="IPaidOrderRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Entities;

namespace RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
#pragma warning disable

public interface IPaidOrderRepository
{
    Task<IEnumerable<PaidOrder>> GetPaidOrders();
    Task<PaidOrder?> GetPaidOrderById(int paidOrderId);
    Task CreatePaidOrder(PaidOrder paidOrder);
    Task DeletePaidOrder(int paidOrderId);
    Task UpdatePaidOrder(PaidOrder paidOrder);
    
}