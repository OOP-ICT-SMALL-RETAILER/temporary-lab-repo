// <copyright file="ServiceCollectionExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
#pragma warning disable
using Microsoft.Extensions.DependencyInjection;
using RetailThings.Application.Contracts.Implementation;
using RetailThings.Application.Contracts.Interfaces;

namespace RetailThings.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IItemService, ItemService>();
        collection.AddScoped<IItemInOrderService, ItemInOrderService>();
        collection.AddScoped<IOrderService, OrderService>();
        collection.AddScoped<IPaidOrderService, PaidOrderService>();
        collection.AddScoped<IPickUpPointService, PickUpPointService>();
        collection.AddScoped<IReviewService, ReviewService>();
        collection.AddScoped<IShopService, ShopService>();
        collection.AddScoped<IUserService, UserService>();
        return collection;
    }
}