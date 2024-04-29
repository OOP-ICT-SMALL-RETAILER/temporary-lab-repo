// <copyright file="ServiceCollectionExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

#pragma warning disable
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RetailThings.Application.Abstractions.Interfaces;
using RetailThings.Application.Events.Commands.ItemInOrder;
using RetailThings.Application.Events.Commands.Items;
using RetailThings.Application.Events.Commands.Order;
using RetailThings.Application.Events.Commands.PaidOrder;
using RetailThings.Application.Events.Commands.PickUp;
using RetailThings.Application.Events.Commands.Review;
using RetailThings.Application.Events.Commands.Shop;
using RetailThings.Application.Events.Commands.User;
using RetailThings.Application.Events.Handlers.ItemInOrder;
using RetailThings.Application.Events.Handlers.Items;
using RetailThings.Application.Events.Handlers.Order;
using RetailThings.Application.Events.Handlers.PaidOrder;
using RetailThings.Application.Events.Handlers.PickUp;
using RetailThings.Application.Events.Handlers.Review;
using RetailThings.Application.Events.Handlers.Shop;
using RetailThings.Application.Events.Handlers.User;
using RetailThings.Application.Events.Queries.ItemInOrder;
using RetailThings.Application.Events.Queries.Items;
using RetailThings.Application.Events.Queries.Order;
using RetailThings.Application.Events.Queries.PaidOrder;
using RetailThings.Application.Events.Queries.PickUp;
using RetailThings.Application.Events.Queries.Review;
using RetailThings.Application.Events.Queries.Shop;
using RetailThings.Application.Events.Queries.User;
using RetailThings.Application.Models.Entities;
using RetailThings.Application.Models.Item;
using RetailThings.Application.Models.ItemInOrder;
using RetailThings.Application.Models.Order;
using RetailThings.Application.Models.PaidOrder;
using RetailThings.Application.Models.Review;
using RetailThings.Application.Models.Shop;
using RetailThings.Application.Services;

namespace RetailThings.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        
        var assembly = AppDomain.CurrentDomain.GetAssemblies().First();
        collection.AddMediatR(x => x.RegisterServicesFromAssembly(assembly)); 
        
        collection.AddScoped<IItemService, ItemService>();
        collection.AddScoped<IOrderService, OrderService>();
        collection.AddScoped<IPaidOrderService, PaidOrderService>();
        collection.AddScoped<IPickUpPointService, PickUpPointService>();
        collection.AddScoped<IReviewService, ReviewService>();
        collection.AddScoped<IShopService, ShopService>();
        collection.AddScoped<IUserService, UserService>();
        collection.AddScoped<IItemInOrderService, ItemInOrderService>();


        AddMediatr(collection);
        
        return collection;
    }

    private static void AddMediatr(IServiceCollection collection)
    {
        collection.AddScoped<IRequestHandler<GetItemQuery, GetItemModel?>, GetItemQueryHandler>();
        collection.AddScoped<IRequestHandler<CreateItemCommand>, CreateItemCommandHandler>();
        collection.AddScoped<IRequestHandler<UpdateItemCommand>, UpdateItemCommandHandler>();
        collection.AddScoped<IRequestHandler<DeleteItemCommand>, DeleteItemCommandHandler>();
        
        collection.AddScoped<IRequestHandler<GetItemInOrderQuery, GetItemInOrderModel?>, GetItemInOrderQueryHandler>();
        collection.AddScoped<IRequestHandler<CreateItemInOrderCommand>, CreateItemInOrderCommandHandler>();
        collection.AddScoped<IRequestHandler<UpdateItemInOrderCommand>, UpdateItemInOrderCommandHandler>();
        collection.AddScoped<IRequestHandler<DeleteItemInOrderCommand>, DeleteItemInOrderCommandHandler>();
        
        collection.AddScoped<IRequestHandler<GetOrderQuery, GetOrderModel?>, GetOrderQueryHandler>();
        collection.AddScoped<IRequestHandler<CreateOrderCommand>, CreateOrderCommandHandler>();
        collection.AddScoped<IRequestHandler<UpdateOrderCommand>, UpdateOrderCommandHandler>();
        collection.AddScoped<IRequestHandler<DeleteOrderCommand>, DeleteOrderCommandHandler>();
        
        collection.AddScoped<IRequestHandler<GetPaidOrderQuery, GetPaidOrderModel?>, GetPaidOrderQueryHandler>();
        collection.AddScoped<IRequestHandler<CreatePaidOrderCommand>, CreatePaidOrderCommandHandler>();
        collection.AddScoped<IRequestHandler<UpdatePaidOrderCommand>, UpdatePaidOrderCommandHandler>();
        collection.AddScoped<IRequestHandler<DeletePaidOrderCommand>, DeletePaidOrderCommandHandler>();
        
        collection.AddScoped<IRequestHandler<GetPickUpQuery, PickUpPoint?>, GetPickUpPointQueryHandler>();
        collection.AddScoped<IRequestHandler<CreatePickUpCommand>, CreatePickUpCommandHandler>();
        collection.AddScoped<IRequestHandler<UpdatePickUpCommand>, UpdatePickUpCommandHandler>();
        collection.AddScoped<IRequestHandler<DeletePickUpCommand>, DeletePickUpCommandHandler>();
        
        collection.AddScoped<IRequestHandler<GetReviewQuery, GetReviewModel?>, GetReviewQueryHandler>();
        collection.AddScoped<IRequestHandler<CreateReviewCommand>, CreateReviewCommandHandler>();
        collection.AddScoped<IRequestHandler<UpdateReviewCommand>, UpdateReviewCommandHandler>();
        collection.AddScoped<IRequestHandler<DeleteReviewCommand>, DeleteReviewCommandHandler>();
        
        collection.AddScoped<IRequestHandler<GetShopQuery, Shop?>, GetShopQueryHandler>();
        collection.AddScoped<IRequestHandler<CreateShopCommand>, CreateShopCommandHandler>();
        collection.AddScoped<IRequestHandler<UpdateShopCommand>, UpdateShopCommandHandler>();
        collection.AddScoped<IRequestHandler<DeleteShopCommand>, DeleteShopCommandHandler>();
        
        collection.AddScoped<IRequestHandler<GetUserQuery, User?>, GetUserQueryHandler>();
        collection.AddScoped<IRequestHandler<CreateUserCommand>, CreateUserCommandHandler>();
        collection.AddScoped<IRequestHandler<UpdateUserCommand>, UpdateUserCommandHandler>();
        collection.AddScoped<IRequestHandler<DeleteUserCommand>, DeleteUserCommandHandler>();
    }
}
