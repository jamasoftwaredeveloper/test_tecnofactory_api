using ApiRestTest.Domain.Entities;

namespace ApiRestTest.Application.Services.LikeComicS.Queries;
using ApiRestTest.Application.Services.LikeComicS.Common;
public interface ILikeComicQueryService
{
      Task<List<LikeComic>> getListLikeComic(string userId);

}