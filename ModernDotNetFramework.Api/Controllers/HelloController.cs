using Microsoft.AspNetCore.Mvc;
using ModernDotNetFramework.Application;
using ModernDotNetFramework.Shared;

namespace ModernDotNetFramework.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    private readonly IGreetingService _greetingService;

    public HelloController(IGreetingService greetingService)
    {
        _greetingService = greetingService;
    }

    [HttpGet]
    public ActionResult<ApiResponse<string>> Get()
    {
        var message = _greetingService.GetLocalizedGreeting();
        return Ok(ApiResponse<string>.SuccessResult(message));
    }
}
