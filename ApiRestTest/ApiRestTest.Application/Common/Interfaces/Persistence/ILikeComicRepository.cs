using ApiRestTest.Domain.Entities;

namespace ApiRestTest.Application.Common.Interfaces.Persistence;

public interface ILikeComicRepository{
    
    Task<LikeComic?> GetLikeById(string userId, int comicId);
    Task Add(LikeComic likeComic);
    Task Update(string userId, int comicId, bool liked);
    Task<List<LikeComic>> GetListLikeComic(string userId);

}