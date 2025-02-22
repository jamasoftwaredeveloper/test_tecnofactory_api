using ApiRestTest.Domain.Entities;

namespace ApiRestTest.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator{
    string GenerateToken(User user);
}