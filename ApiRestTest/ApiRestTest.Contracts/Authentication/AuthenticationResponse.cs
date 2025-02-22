namespace ApiRestTest.Contracts.Authentication;
public record AuthenticationResponse (
    Guid Id,
    string Name,
    string Nuip,
    string Email,
    string Token
);