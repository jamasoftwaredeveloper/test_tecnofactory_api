namespace ApiRestTest.Domain.Entities;

public class LikeComic
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool Like { get; set; } = true;
    public int? ComicId { get; set; }
    public string UserId { get; set; } = null!;
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Thumbnail { get; set; }
 }