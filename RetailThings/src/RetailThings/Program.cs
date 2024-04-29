// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

#pragma warning disable CA1506
#pragma warning disable SA1210
using Itmo.Dev.Platform.Common.Extensions;
using Itmo.Dev.Platform.Logging.Extensions;
using Microsoft.EntityFrameworkCore;

// using Microsoft.EntityFrameworkCore;
using RetailThings.Application.Extensions;
using RetailThings.Infrastructure.Persistence.Extensions;
using RetailThings.Presentation.Http.Extensions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RetailThings.Infrastructure.Persistence.Contexts;
using RetailThings.Presentation.Http.Middleswares;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();

builder.Services.AddOptions<JsonSerializerSettings>();
builder.Services.AddSingleton(sp => sp.GetRequiredService<IOptions<JsonSerializerSettings>>().Value);

builder.Services
    .AddControllers()
    .AddNewtonsoftJson()
    .AddPresentationHttp();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host.AddPlatformSerilog(builder.Configuration);
builder.Services.AddUtcDateTimeProvider();

builder.Services.AddInfrastructurePersistence(builder.Configuration);
builder.Services.AddApplication();


WebApplication app = builder.Build();

await using (AsyncServiceScope scope = app.Services.CreateAsyncScope())
{
    IServiceProvider services = scope.ServiceProvider;

    ApplicationContext context = services.GetRequiredService<ApplicationContext>();
    await context.Database.MigrateAsync();
}

app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.UseMiddleware<LoggingMiddleware>();

await app.RunAsync();