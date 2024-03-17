namespace RetailMarketplace.Presentation.Grpc.Extensions;

using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationGrpc(this IServiceCollection collection)
    {
        collection.AddGrpc();
        collection.AddGrpcReflection();

        return collection;
    }
}