// <copyright file="IUserService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.User;

namespace RetailThings.Application.Abstractions.Interfaces;
#pragma warning disable

public interface IUserService
{
    Task<IEnumerable<User>> GetUsers();
    Task<User?> GetUserById(int userId);
    Task CreateUser(CreateUserModel user);
    Task DeleteUser(int userId);
    Task UpdateUser(CreateUserModel user);
}