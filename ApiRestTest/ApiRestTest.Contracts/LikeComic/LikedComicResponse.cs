namespace ApiRestTest.Contracts.Authentication;
public record LikedComicResponse(
    List<LikeComic> LikeComicList
);
public record LikeComic(
    Guid Id,
    string UserId,
    int? CommicId,
    bool Like
);
