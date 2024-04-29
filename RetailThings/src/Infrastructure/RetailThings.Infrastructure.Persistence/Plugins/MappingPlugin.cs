// <copyright file="MappingPlugin.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Itmo.Dev.Platform.Postgres.Plugins;
using Npgsql;

namespace RetailThings.Infrastructure.Persistence.Plugins;

/// <summary>
///     Plugin for configuring NpgsqlDataSource's mappings
///     ie: enums, composite types.
/// </summary>
public class MappingPlugin : IDataSourcePlugin
{
#pragma warning disable SA1600
    public void Configure(NpgsqlDataSourceBuilder builder)
    {
    }
#pragma warning restore SA1600
}