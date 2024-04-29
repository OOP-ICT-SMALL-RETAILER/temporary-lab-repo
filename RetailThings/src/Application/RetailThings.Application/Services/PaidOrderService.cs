// <copyright file="PaidOrderService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.PaidOrder;

#pragma warning disable

namespace RetailThings.Application.Services;

public class PaidOrderService : IPaidOrderService
{
    private readonly IPaidOrderRepository _paidOrderRepository;

    public PaidOrderService(IPaidOrderRepository paidOrderRepository)
    {
        _paidOrderRepository = paidOrderRepository;
    }

    public async Task<IEnumerable<GetPaidOrderModel>> GetPaidOrders()
    {
        return (await _paidOrderRepository.GetPaidOrders())
            .Select(result => new GetPaidOrderModel()
            {
                PaidOrderId = result.PaidOrderId,
                DatePaid = result.DatePaid,
                OrderId = result.OrderId,
            });
    }

    public async Task<GetPaidOrderModel?> GetPaidOrderById(int paidOrderId)
    {
        var result = await _paidOrderRepository.GetPaidOrderById(paidOrderId);

        if (result is null)
            return null;

        return new GetPaidOrderModel()
        {
            PaidOrderId = result.PaidOrderId,
            DatePaid = result.DatePaid,
            OrderId = result.OrderId,
        };
    }

    public async Task CreatePaidOrder(CreatePaidOrderModel paidOrder)
    {
        await _paidOrderRepository.CreatePaidOrder(new PaidOrder()
        {
            OrderId = paidOrder.OrderId,
            DatePaid = DateTime.UtcNow,
        });
    }

    public async Task DeletePaidOrder(int paidOrderId)
    {
        await _paidOrderRepository.DeletePaidOrder(paidOrderId);
    }

    public async Task UpdatePaidOrder(CreatePaidOrderModel paidOrder)
    {
        await _paidOrderRepository.UpdatePaidOrder(new PaidOrder()
        {
            OrderId = paidOrder.OrderId,
            DatePaid = DateTime.UtcNow,
        });
    }
}
