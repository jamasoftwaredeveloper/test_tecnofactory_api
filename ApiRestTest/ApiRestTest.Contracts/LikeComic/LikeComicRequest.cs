
public record LikeComicRequest(
    string UserId,
    int ComicId,
    string Thumbnail,
    string Title,
    string? Description,
    bool Like
);