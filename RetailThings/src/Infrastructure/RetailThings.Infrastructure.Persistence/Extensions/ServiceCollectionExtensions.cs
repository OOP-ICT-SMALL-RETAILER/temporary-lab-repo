// <copyright file="ServiceCollectionExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
#pragma warning disable
using Itmo.Dev.Platform.Postgres.Models;
using Itmo.Dev.Platform.Postgres.Plugins;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RetailThings.Infrastructure.Persistence.Contexts;
using RetailThings.Infrastructure.Persistence.Plugins;

namespace RetailThings.Infrastructure.Persistence.Extensions;


public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructurePersistence(this IServiceCollection collection, IConfiguration configuration)
    {
        var postgresConnectionConfiguration =
            new PostgresConnectionConfiguration();

        postgresConnectionConfiguration.Host =
            configuration.GetSection("Infrastructure:Persistence:Postgres:Host").Value!;
        postgresConnectionConfiguration.Port =
            int.Parse(configuration.GetSection("Infrastructure:Persistence:Postgres:Port").Value!);
        postgresConnectionConfiguration.Database =
            configuration.GetSection("Infrastructure:Persistence:Postgres:Database").Value!;
        postgresConnectionConfiguration.Username =
            configuration.GetSection("Infrastructure:Persistence:Postgres:Username").Value!;
        postgresConnectionConfiguration.Password =
            configuration.GetSection("Infrastructure:Persistence:Postgres:Password").Value!;

        collection.AddSingleton(postgresConnectionConfiguration);
        collection.AddDbContext<ApplicationContext>(options =>
            options.UseNpgsql(postgresConnectionConfiguration.ToConnectionString()));
        collection.AddSingleton<IDataSourcePlugin, MappingPlugin>();

        // collection.AddPlatformMigrations(typeof(IAssemblyMarker).Assembly);
        // collection.AddHostedService<MigrationRunnerService>();
        
        return collection;
    }
}