using API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("errors")]
public class ErrorController : BaseApiController
{
    [HttpGet("{code}")]
    [HttpPost("{code}")]
    public IActionResult Error(int code)
    {
        return new ObjectResult(new ApiResponse(code));
    }
}