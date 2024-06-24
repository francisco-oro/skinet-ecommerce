using API.Errors;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/// <summary>
/// Handles different types of HTTP response errors that may occur in the application
/// </summary>
public class BuggyController : BaseApiController
{
    private readonly StoreContext _storeContext;

    /// <summary>
    /// Constructor method
    /// </summary>
    /// <param name="storeContext">Database context</param>
    public BuggyController(StoreContext storeContext)
    {
        _storeContext = storeContext;
    } 
    
    /// <summary>
    /// Responds to HTTP GET requests to the /api/BuggyController/notfound
    /// and attempts to find a product in the database context
    /// </summary>
    /// <returns>
    /// If the product is not found, the action returns a NotFound response with an ApiResponse object containing a 404 status code
    /// If the product is found, the action returns an Ok response.
    /// </returns>

    [HttpGet("notfound")]
    public ActionResult GetNotFoundRequest()
    {
        var thing = _storeContext.Products.Find(Guid.Empty);
        if (thing == null)
        {
            return NotFound(new ApiResponse(404));
        }
        return Ok();
    }

    /// <summary>
    /// Responds to HTTP GET requests to the /api/BuggyController/servererror
    /// and intentionally generates an exception 
    /// </summary>
    /// <returns>
    /// If an error occurs during the execution of the action, the action will return a status 500 response
    /// </returns>
    [HttpGet("servererror")]
    public ActionResult GetServerError()
    {
        var thing = _storeContext.Products.Find(Guid.Empty);

        var thingToReturn = thing.ToString();
        return Ok();
    }
    /// <summary>
    /// Responds to HTTP GET requests to the /api/BuggyController/badrequest
    /// and returns a bad request response with an ApiResponse object containing a 400 status code
    /// </summary>
    /// <returns>
    /// A status 400 BadResponse instance, using the ApiResponse class
    /// </returns>
    [HttpGet("badrequest")]
    public ActionResult GetBadRequest()
    {
        return BadRequest(new ApiResponse(400));
    }
    
    /// <summary>
    /// Responds to HTTP GET requests to the /api/BuggyController/badrequest/{id}
    /// and returns a bad request response with an ApiResponse object containing a 400 status code
    /// </summary>
    /// <param name="id">Guid key of the object to search</param>
    /// <returns>A 400 status Ok response</returns>
    [HttpGet("badrequest/{id}")]
    public ActionResult GetNotFoundRequest(Guid id)
    {
        return Ok();
    }
}