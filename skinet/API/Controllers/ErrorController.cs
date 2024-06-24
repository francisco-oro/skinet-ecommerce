using API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/// <summary>
/// /// The ErrorController class is responsible for handling error responses in the application.
/// This controller is mapped to the "errors" route and is set to be ignored by the API explorer.
/// </summary>
[Route("errors")]
[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorController : BaseApiController
{
    /// <summary>
    /// Returns an error response with the specified status code.
    /// </summary>
    /// <param name="code">The HTTP status code to be returned in the error response.</param>
    /// <returns>And ObjectResult containing an ApiResponse with the specified status code.</returns>
    public IActionResult Error(int code)
    {
        return new ObjectResult(new ApiResponse(code));
    }
}