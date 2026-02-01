using System;
using ModernDotNetFramework.Shared;

namespace ModernDotNetFramework.CLI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"🦞 {Constants.FrameworkName} CLI v{Constants.Version}");
        Console.WriteLine("------------------------------------------------");

        if (args.Length == 0)
        {
            ShowHelp();
            return;
        }

        switch (args[0].ToLower())
        {
            case "gateway":
                Console.WriteLine("Starting Gateway plane...");
                break;
            case "onboard":
                Console.WriteLine("Running onboarding wizard...");
                break;
            case "doctor":
                Console.WriteLine("Running system diagnostics...");
                break;
            default:
                Console.WriteLine($"Unknown command: {args[0]}");
                ShowHelp();
                break;
        }
    }

    static void ShowHelp()
    {
        Console.WriteLine("Usage: openclaw [command]");
        Console.WriteLine("");
        Console.WriteLine("Commands:");
        Console.WriteLine("  gateway    Start the gateway control plane");
        Console.WriteLine("  onboard    Run the setup wizard");
        Console.WriteLine("  doctor     Check system health");
    }
}
