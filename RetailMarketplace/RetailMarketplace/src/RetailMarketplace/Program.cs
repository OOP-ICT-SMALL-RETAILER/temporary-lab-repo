#pragma warning disable CA1506

using Itmo.Dev.Platform.Common.Extensions;
using Itmo.Dev.Platform.Events;
using Itmo.Dev.Platform.Logging.Extensions;
using Itmo.Dev.Platform.YandexCloud.Extensions;
using RetailMarketplace.Application.Extensions;
using RetailMarketplace.Infrastructure.Persistence.Extensions;
using RetailMarketplace.Presentation.Grpc.Extensions;
using RetailMarketplace.Presentation.Kafka.Extensions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();
await builder.AddYandexCloudConfigurationAsync();

builder.Services.AddOptions<JsonSerializerSettings>();
builder.Services.AddSingleton(sp => sp.GetRequiredService<IOptions<JsonSerializerSettings>>().Value);

builder.Services.AddApplication();
builder.Services.AddInfrastructurePersistence();
builder.Services.AddPresentationGrpc();
builder.Services.AddPresentationKafka(builder.Configuration);


builder.Services.AddPlatformEvents(b => b.AddPresentationKafkaHandlers());

builder.Host.AddPlatformSerilog(builder.Configuration);
builder.Services.AddUtcDateTimeProvider();
builder.AddPlatformSentry();

WebApplication app = builder.Build();


app.UseRouting();
app.UsePlatformSentryTracing(app.Configuration);

app.UsePresentationGrpc();

await app.RunAsync();