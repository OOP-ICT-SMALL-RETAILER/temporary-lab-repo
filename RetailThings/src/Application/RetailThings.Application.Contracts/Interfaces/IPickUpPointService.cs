// <copyright file="IPickUpPointService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Application.Contracts.Interfaces;
#pragma warning disable

public interface IPickUpPointService
{
    IEnumerable<PickUpPoint> GetPickUpPoints();
    PickUpPoint GetPickUpPointById(int pickUpPointId);
    void CreatePickUpPoint(PickUpPoint pickUpPoint);
    void DeletePickUpPoint(int pickUpPointId);
    void UpdatePickUpPoint(PickUpPoint pickUpPoint);
}