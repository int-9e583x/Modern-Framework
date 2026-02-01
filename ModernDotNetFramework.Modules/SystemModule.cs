using ModernDotNetFramework.Core.Interfaces;

namespace ModernDotNetFramework.Modules;

public class SystemModule : IModule
{
    public string Name => "SystemModule";
    public string Description => "Handles system-level commands and diagnostics.";

    public Task InitializeAsync()
    {
        // Initialization logic
        return Task.CompletedTask;
    }

    public Task ExecuteAsync(string command)
    {
        Console.WriteLine($"[SystemModule] Executing command: {command}");
        return Task.CompletedTask;
    }
}
