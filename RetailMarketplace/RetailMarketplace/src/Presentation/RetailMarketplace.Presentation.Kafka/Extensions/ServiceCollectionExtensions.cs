namespace RetailMarketplace.Presentation.Kafka.Extensions;

using System.Reflection;
using Itmo.Dev.Platform.Kafka.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationKafka(
        this IServiceCollection collection,
        IConfiguration configuration)
    {
        const string consumerKey = "Presentation:Kafka:Consumers";
        const string producerKey = "Presentation:Kafka:Producers";

        string group = Assembly.GetExecutingAssembly().GetName().Name ?? string.Empty;

        // TODO: add consumers and producers
        // consumer example:
        // .AddConsumer(b => b
        //     .WithKey<MessageKey>()
        //     .WithValue<MessageValue>()
        //     .WithConfiguration(configuration.GetSection($"{consumerKey}:MessageName"))
        //     .DeserializeKeyWithProto()
        //     .DeserializeValueWithProto()
        //     .HandleWith<MessageHandler>())
        //
        // producer example:
        // .AddProducer(b => b
        //     .WithKey<MessageKey>()
        //     .WithValue<MessageValue>()
        //     .WithConfiguration(configuration.GetSection($"{producerKey}:MessageName"))
        //     .SerializeKeyWithProto()
        //     .SerializeValueWithProto())
        collection.AddPlatformKafka(builder => builder
            .ConfigureOptions(configuration.GetSection("Presentation:Kafka")));

        return collection;
    }
}