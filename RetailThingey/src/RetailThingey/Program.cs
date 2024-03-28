#pragma warning disable CA1506
#pragma warning disable SA1516
#pragma warning restore SA1516

using Itmo.Dev.Platform.Common.Extensions;
using Itmo.Dev.Platform.Logging.Extensions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RetailThingey.Application.Extensions;
using RetailThingey.Infrastructure.Persistence.Extensions;
using RetailThingey.Presentation.Http.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();

builder.Services.AddOptions<JsonSerializerSettings>();
builder.Services.AddSingleton(sp => sp.GetRequiredService<IOptions<JsonSerializerSettings>>().Value);

builder.Services.AddApplication();
builder.Services.AddInfrastructurePersistence(builder.Configuration);
builder.Services
    .AddControllers()
    .AddNewtonsoftJson()
    .AddPresentationHttp();

builder.Services.AddSwaggerGen().AddEndpointsApiExplorer();

builder.Host.AddPlatformSerilog(builder.Configuration);
builder.Services.AddUtcDateTimeProvider();

WebApplication app = builder.Build();

app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

await app.RunAsync();