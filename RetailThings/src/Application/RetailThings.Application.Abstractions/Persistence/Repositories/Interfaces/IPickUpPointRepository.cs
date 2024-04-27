// <copyright file="IPickUpPointRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Entities;

namespace RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
#pragma warning disable

public interface IPickUpPointRepository
{
    Task<IEnumerable<PickUpPoint>> GetPickUpPoints();
    Task<PickUpPoint?> GetPickUpPointById(int pickUpPointId);
    Task CreatePickUpPoint(PickUpPoint pickUpPoint);
    Task DeletePickUpPoint(int pickUpPointId);
    Task UpdatePickUpPoint(PickUpPoint pickUpPoint);
}