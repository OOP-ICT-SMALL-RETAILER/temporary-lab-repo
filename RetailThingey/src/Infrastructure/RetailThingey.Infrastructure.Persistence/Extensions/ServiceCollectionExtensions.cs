using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Plugins;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using RetailThingey.Application.Abstractions.Persistence;
using RetailThingey.Infrastructure.Persistence.Contexts;
using RetailThingey.Infrastructure.Persistence.Migrations;
using RetailThingey.Infrastructure.Persistence.Plugins;

namespace RetailThingey.Infrastructure.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructurePersistence(
        this IServiceCollection collection,
        ConfigurationManager<string> builderConfiguration)
    {
        collection.AddPlatformPostgres(builder => builder.BindConfiguration("Infrastructure:Persistence:Postgres"));
        collection.AddSingleton<IDataSourcePlugin, MappingPlugin>();

        collection.AddPlatformMigrations(typeof(IAssemblyMarker).Assembly);
        collection.AddHostedService<MigrationRunnerService>();

        // TODO: add repositories
        collection.AddScoped<IPersistenceContext, PersistenceContext>();

        return collection;
    }

    public static IServiceCollection AddInfrastructurePersistence(
        this IServiceCollection collection,
        IConfiguration configuration)
    {
        collection.AddDbContext<ApplicationDbContext>(
            options =>
                options.UseNpgsql(
                    configuration.GetSection("Infrastructure:Persistence:Postgres:ConnectionString").Value));
        return collection;
    }
}