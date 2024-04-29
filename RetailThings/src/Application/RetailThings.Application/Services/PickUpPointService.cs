// <copyright file="PickUpPointService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.PickUpPoint;

#pragma warning disable

namespace RetailThings.Application.Services;

public class PickUpPointService : IPickUpPointService
{
    private readonly IPickUpPointRepository _pickUpPointRepository;

    public PickUpPointService(IPickUpPointRepository pickUpPointRepository)
    {
        _pickUpPointRepository = pickUpPointRepository;
    }

    public async Task<IEnumerable<PickUpPoint>> GetPickUpPoints()
    {
        return await _pickUpPointRepository.GetPickUpPoints();
    }

    public async Task<PickUpPoint?> GetPickUpPointById(int pickUpPointId)
    {
        return await _pickUpPointRepository.GetPickUpPointById(pickUpPointId);
    }

    public async Task CreatePickUpPoint(CreatePickUpPointModel pickUpPoint)
    {
        await _pickUpPointRepository.CreatePickUpPoint(new PickUpPoint()
        {
            Title = pickUpPoint.Title,
            Address = pickUpPoint.Address,
        });
    }

    public async Task DeletePickUpPoint(int pickUpPointId)
    {
        await _pickUpPointRepository.DeletePickUpPoint(pickUpPointId);
    }

    public async Task UpdatePickUpPoint(CreatePickUpPointModel pickUpPoint)
    {
        _pickUpPointRepository.UpdatePickUpPoint(new PickUpPoint()
        {
            Title = pickUpPoint.Title,
            Address = pickUpPoint.Address,
        });
    }
}
