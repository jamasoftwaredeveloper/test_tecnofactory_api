namespace ApiRestTest.Contracts.Authentication;

public record RegisterRequest (
    string Name,
    string Nuip,
    string Email,
    string Password
);