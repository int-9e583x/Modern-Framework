using Microsoft.AspNetCore.Localization;
using System.Globalization;
using ModernDotNetFramework.Application;
using ModernDotNetFramework.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1. Configure Localization
builder.Services.AddLocalization();

// 2. Register Application Services
builder.Services.AddScoped<IGreetingService, GreetingService>();

var app = builder.Build();

// 3. Configure Supported Cultures
var supportedCultures = new[] { "en", "zh" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("en")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
