// <copyright file="UserService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Contracts.Interfaces;
using RetailThings.Infrastructure.Persistence.Contexts;
using RetailThings.Infrastructure.Persistence.Entities;

namespace RetailThings.Application.Contracts.Implementation;
#pragma warning disable

public class UserService : IUserService
{
    private ApplicationContext _applicationContext;
    private bool disposed = false;

    public UserService(ApplicationContext applicationContext)
    {
        _applicationContext = _applicationContext;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _applicationContext.Dispose();
            }
        }
        this.disposed = true;
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public IEnumerable<User> GetUsers()
    {
        return _applicationContext.Users.ToList();
    }

    public User GetUserById(int userId)
    {
        return _applicationContext.Users.Find(userId);
    }

    public void CreateUser(User user)
    {
        _applicationContext.Users.Add(user);
    }

    public void DeleteUser(int userId)
    {
        User user = _applicationContext.Users
            .Find(userId);
        _applicationContext.Users.Remove(user);    }

    public void UpdateUser(User user)
    {
        _applicationContext.Entry(user).State = EntityState.Modified;
    }

    public void Save()
    {
        _applicationContext.SaveChanges();
    }
}