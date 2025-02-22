using ApiRestTest.Application.Services.Authentication.Common;

namespace ApiRestTest.Application.Services.Authentication;

public interface IAuthQueryService
{
    Task<AuthResult> Login(string email, string password);

}