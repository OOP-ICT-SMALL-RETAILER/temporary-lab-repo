// <copyright file="UserService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Abstractions.Persistence.Repositories.Interfaces;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.User;

namespace RetailThings.Application.Services;
#pragma warning disable

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        return await _userRepository.GetUsers();
    }

    public async Task<User?> GetUserById(int userId)
    {
        return await _userRepository.GetUserById(userId);
    }

    public async Task CreateUser(CreateUserModel user)
    {
        await _userRepository.CreateUser(new User()
        {
            Name = user.Name,
            Email = user.Email,
            Password = user.Password,
        });
    }

    public async Task DeleteUser(int userId)
    {
        await _userRepository.DeleteUser(userId);
    }

    public async Task UpdateUser(CreateUserModel user)
    {
        await _userRepository.UpdateUser(new User()
        {
            Name = user.Name,
            Email = user.Email,
            Password = user.Password,
        });
    }
}
