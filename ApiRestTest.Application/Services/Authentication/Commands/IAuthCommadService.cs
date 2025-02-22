using ApiRestTest.Application.Services.Authentication.Common;

namespace ApiRestTest.Application.Services.Authentication.Commands;

public interface IAuthCommadService
{
    Task<AuthResult> Login(string email, string password);
    Task<AuthResult> Register(string name, string nuip, string email, string password);

}