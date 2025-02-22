namespace ApiRestTest.Application.Services.LikeComicS.Queries;
using ApiRestTest.Application.Services.LikeComicS.Common;
using ApiRestTest.Application.Common.Interfaces.Persistence;
using ApiRestTest.Domain.Entities;


public class LikeComicQueryService : ILikeComicQueryService
{

    private readonly ILikeComicRepository _likeComicRepository;

    public LikeComicQueryService(ILikeComicRepository userRepository)
    {
        _likeComicRepository = userRepository;
    }

    public async Task<List<LikeComic>> getListLikeComic(string userId)
    {
        var liked = await _likeComicRepository.GetListLikeComic(userId);

        return
             liked;
    }
}
