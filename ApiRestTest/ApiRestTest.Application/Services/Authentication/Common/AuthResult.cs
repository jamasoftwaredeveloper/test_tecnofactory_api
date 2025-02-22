using ApiRestTest.Domain.Entities;

namespace ApiRestTest.Application.Services.Authentication.Common;

public record AuthResult(
    User User,
    string Token
);

