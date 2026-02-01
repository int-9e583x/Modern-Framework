using Microsoft.AspNetCore.Mvc;
using ModernDotNetFramework.Core;
using ModernDotNetFramework.Infrastructure;

namespace ModernDotNetFramework.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FrameworkController : ControllerBase
{
    private readonly ISimpleLogger _logger;

    public FrameworkController(ISimpleLogger logger)
    {
        _logger = logger;
    }

    [HttpGet("status")]
    public ActionResult<ApiResponse<string>> GetStatus()
    {
        _logger.LogInfo("Status endpoint was called.");
        return Ok(ApiResponse<string>.SuccessResult("Framework is running smoothly!", "Status check successful"));
    }

    [HttpGet("info")]
    public ActionResult<ApiResponse<object>> GetInfo()
    {
        var info = new
        {
            Framework = ".NET 8.0",
            Architecture = "Clean Architecture (Lite)",
            Author = "Manus Agent",
            Features = new[] { "Dependency Injection", "Swagger/OpenAPI", "Multi-layer Project Structure" }
        };
        return Ok(ApiResponse<object>.SuccessResult(info, "Framework info retrieved"));
    }
}
