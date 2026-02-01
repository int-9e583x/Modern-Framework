using Microsoft.Extensions.Logging;

namespace ModernDotNetFramework.Infrastructure;

public interface ISimpleLogger
{
    void LogInfo(string message);
}

public class SimpleLogger : ISimpleLogger
{
    private readonly ILogger<SimpleLogger> _logger;

    public SimpleLogger(ILogger<SimpleLogger> logger)
    {
        _logger = logger;
    }

    public void LogInfo(string message)
    {
        _logger.LogInformation($"[Custom Log] {message}");
    }
}
