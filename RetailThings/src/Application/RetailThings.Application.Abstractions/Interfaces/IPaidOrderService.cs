// <copyright file="IPaidOrderService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.PaidOrder;

namespace RetailThings.Application.Abstractions.Interfaces;
#pragma warning disable

public interface IPaidOrderService
{
    Task<IEnumerable<GetPaidOrderModel>> GetPaidOrders();
    Task<GetPaidOrderModel?> GetPaidOrderById(int paidOrderId);
    Task CreatePaidOrder(CreatePaidOrderModel paidOrder);
    Task DeletePaidOrder(int paidOrderId);
    Task UpdatePaidOrder(CreatePaidOrderModel paidOrder);
    
}