using Microsoft.Extensions.Localization;
using ModernDotNetFramework.Application;
using ModernDotNetFramework.Shared.Resources;

namespace ModernDotNetFramework.Infrastructure;

public class GreetingService : IGreetingService
{
    private readonly IStringLocalizer<Resource> _localizer;

    public GreetingService(IStringLocalizer<Resource> localizer)
    {
        _localizer = localizer;
    }

    public string GetLocalizedGreeting()
    {
        return _localizer["Welcome"];
    }
}
