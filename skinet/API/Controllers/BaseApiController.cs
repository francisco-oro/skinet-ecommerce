using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/// <summary>
/// Controller class to provide a common foundation for other API controllers ini the application
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    
}