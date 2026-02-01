namespace ModernDotNetFramework.Shared;

public static class Constants
{
    public const string Version = "2026.2.1";
    public const string FrameworkName = "ModernDotNetFramework";
    public const string DefaultCulture = "en";
}

public class BaseResponse<T>
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public T? Data { get; set; }
}
