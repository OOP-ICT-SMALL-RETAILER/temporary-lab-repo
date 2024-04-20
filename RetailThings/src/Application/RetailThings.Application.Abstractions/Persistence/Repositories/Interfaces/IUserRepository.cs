// <copyright file="IUserRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Application.Contracts.Interfaces;
#pragma warning disable

public interface IUserRepository : IDisposable
{
    IEnumerable<User> GetUsers();
    User GetUserById(int userId);
    void CreateUser(User user);
    void DeleteUser(int userId);
    void UpdateUser(User user);
    void Save();
}