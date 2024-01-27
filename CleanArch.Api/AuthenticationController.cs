using CleanArch.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;
namespace CleanArch.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        return Ok(request);
    }
    [HttpPost("login")]
    public ActionResult Login(LoginRequest reuest)
    {
        return Ok(reuest);
    }

}