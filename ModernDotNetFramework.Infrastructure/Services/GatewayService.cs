using ModernDotNetFramework.Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace ModernDotNetFramework.Infrastructure.Services;

public class GatewayService : IGatewayService
{
    private readonly ILogger<GatewayService> _logger;
    private bool _isRunning;

    public GatewayService(ILogger<GatewayService> logger)
    {
        _logger = logger;
    }

    public string GetStatus() => _isRunning ? "Running" : "Stopped";

    public Task StartAsync()
    {
        _isRunning = true;
        _logger.LogInformation("Gateway Service Started.");
        return Task.CompletedTask;
    }

    public Task StopAsync()
    {
        _isRunning = false;
        _logger.LogInformation("Gateway Service Stopped.");
        return Task.CompletedTask;
    }
}
