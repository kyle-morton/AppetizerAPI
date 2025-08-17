using Microsoft.AspNetCore.Mvc;

namespace AppetizersAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{

    private string _apiKey;
    
    public AccountController(IConfiguration config)
    {
        _apiKey = config["api-key"];
        if (string.IsNullOrEmpty(_apiKey))
        {
            throw new Exception("API key not set");
        }
    }
    
    [HttpPost]
    public IActionResult SaveAccountChanges()
    {
        var apiKeyHeader = Request.Headers["api-key"].FirstOrDefault();

        if (string.IsNullOrEmpty(apiKeyHeader) || !apiKeyHeader.Equals(_apiKey))
        {
            return Unauthorized();
        }
        
        return Ok(new
        {
        });
    }

}

