namespace ApiRestTest.Contracts.Authentication;
public record LikeComicResponse(
    Guid Id,
    string UserId,
    int? CommicId,
    string? Thumbnail,
    string? Title,
    string? Description,
    bool Like

);
