using AppetizerAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppetizersAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private string _apiKey;

    public UserController(IConfiguration config, IUserService userService)
    {
        _userService = userService;
        _apiKey = config["api-key"];
        
        if (string.IsNullOrEmpty(_apiKey))
        {
            throw new Exception("API key not set");
        }
    }

    [HttpPost]
    [Route("Create")]
    public async Task<IActionResult> CreateUser([FromBody] User user)
    {
        if (!IsAuthorized())
        {
            return Unauthorized();
        }

        user = await _userService.CreateUser(user);

        return Ok(user);
    }

    [HttpPost]
    [Route("Update")]
    public async Task<IActionResult> UpdateUser()
    {
        if (!IsAuthorized())
        {
            return Unauthorized();
        }

        // await _userService.UpdateUser();

        return Ok();
    }

    [HttpPost]
    [Route("")]
    public IActionResult SaveAccountChanges()
    {
        if (!IsAuthorized())
        {
            return Unauthorized();
        }

        return Ok(new
        {

        });
    }

    private bool IsAuthorized()
    {
        var apiKeyHeader = Request.Headers["api-key"].FirstOrDefault();

        return !string.IsNullOrEmpty(apiKeyHeader) && apiKeyHeader.Equals(_apiKey);
    }

}

