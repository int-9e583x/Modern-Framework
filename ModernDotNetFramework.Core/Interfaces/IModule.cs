namespace ModernDotNetFramework.Core.Interfaces;

public interface IModule
{
    string Name { get; }
    string Description { get; }
    Task InitializeAsync();
    Task ExecuteAsync(string command);
}

public interface IGatewayService
{
    string GetStatus();
    Task StartAsync();
    Task StopAsync();
}
