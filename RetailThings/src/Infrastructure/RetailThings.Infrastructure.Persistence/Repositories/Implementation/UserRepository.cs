// <copyright file="UserRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Infrastructure.Persistence.Contexts;

namespace RetailThings.Infrastructure.Persistence.Repositories.Implementation;
#pragma warning disable

public class UserRepository : IUserRepository
{
    private readonly ApplicationContext _applicationContext;

    public UserRepository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        return await _applicationContext.Users.ToListAsync();
    }

    public async Task<User?> GetUserById(int userId)
    {
        return await _applicationContext.Users.FindAsync(userId);
    }

    public async Task CreateUser(User user)
    {
        _applicationContext.Users.AddAsync(user);

        await _applicationContext.SaveChangesAsync();
    }

    public async Task DeleteUser(int userId)
    {
        User? user = await _applicationContext.Users
            .FindAsync(userId);

        _applicationContext.Users.Remove(user);

        await _applicationContext.SaveChangesAsync();
    }

    public async Task UpdateUser(User user)
    {
        _applicationContext.Entry(user).State = EntityState.Modified;

        await _applicationContext.SaveChangesAsync();
    }
}
