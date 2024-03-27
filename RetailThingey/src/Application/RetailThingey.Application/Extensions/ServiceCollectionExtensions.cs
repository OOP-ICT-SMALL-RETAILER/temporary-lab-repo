using Microsoft.Extensions.DependencyInjection;
using RetailThingey.Application.Extensions.Buisnesslogic;

namespace RetailThingey.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        // TODO: add services
        collection.AddScoped<ICartPayService, CartPayService>();
        collection.AddScoped<IPaymentPayService, PaymentPayService>();
        collection.AddScoped<ICartService, CartService>();
        collection.AddScoped<IDeliveryPointService, DeliveryPointService>();
        collection.AddScoped<IDeliveryPointRepository, DeliveryPointRepository>();
        collection.AddScoped<IProductPriceService, ProductPriceService>();
        collection.AddScoped<IProductService, ProductService>();
        collection.AddScoped<IReviewService, ReviewService>();
        return collection;
    }
}