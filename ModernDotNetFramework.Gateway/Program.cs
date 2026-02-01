using ModernDotNetFramework.Core.Interfaces;
using ModernDotNetFramework.Infrastructure.Services;
using ModernDotNetFramework.Modules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Core Services (OpenClaw Style)
builder.Services.AddSingleton<IGatewayService, GatewayService>();

// Register Modules as Scoped
builder.Services.AddScoped<IModule, SystemModule>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Auto-start Gateway Service
using (var scope = app.Services.CreateScope())
{
    var gateway = scope.ServiceProvider.GetRequiredService<IGatewayService>();
    await gateway.StartAsync();
}

app.Run();
