using ApiRestTest.Api.Filters;
using ApiRestTest.Application.Services.Authentication;
using ApiRestTest.Application.Services.Authentication.Commands;
using ApiRestTest.Contracts.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestTest.Api.Controllers;

[ApiController]
[Route("auth")]
[AllowAnonymous]
public class AuthenticationController : ControllerBase
{

    private readonly IAuthCommadService _authCommandService;
    private readonly IAuthQueryService _authQueryService;

    public AuthenticationController(IAuthCommadService authService, IAuthQueryService authQueryService)
    {
        _authCommandService = authService;
        _authQueryService = authQueryService;
    }

    [HttpPost("register")]
    public async Task<AuthenticationResponse>  Register(RegisterRequest request)
    {
        var authResult = await _authCommandService.Register(request.Name, request.Nuip, request.Email, request.Password);

        var response = new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.Name,
            authResult.User.Nuip,
            authResult.User.Email,
            authResult.Token
        );

        return response;
    }

    [HttpPost("login")]
    public async Task<AuthenticationResponse>  Login(LoginRequest request)
    {
        var authResult = await _authQueryService.Login(request.Email, request.Password);

        var response = new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.Name,
            authResult.User.Nuip,
            authResult.User.Email,
            authResult.Token
        );

        return response;
    }
}