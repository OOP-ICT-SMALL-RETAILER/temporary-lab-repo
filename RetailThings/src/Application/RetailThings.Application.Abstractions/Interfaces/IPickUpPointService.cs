// <copyright file="IPickUpPointService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.PickUpPoint;

namespace RetailThings.Application.Abstractions.Interfaces;
#pragma warning disable

public interface IPickUpPointService
{
    Task<IEnumerable<PickUpPoint>> GetPickUpPoints();
    Task<PickUpPoint?> GetPickUpPointById(int pickUpPointId);
    Task CreatePickUpPoint(CreatePickUpPointModel pickUpPoint);
    Task DeletePickUpPoint(int pickUpPointId);
    Task UpdatePickUpPoint(CreatePickUpPointModel pickUpPoint);
}