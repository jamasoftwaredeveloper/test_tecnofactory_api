using ApiRestTest.Application.Services.LikeComicS.Commads;
using ApiRestTest.Application.Services.LikeComicS.Queries;
using ApiRestTest.Contracts.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiRestTest.Api.Controllers;

[ApiController]
[Route("like")]
[Authorize]
public class LikeComicController : ControllerBase
{
    private readonly ILikeComicCommadService _likeComicCommandService;
    private readonly ILikeComicQueryService _likeComicQueryService;

    public LikeComicController(ILikeComicCommadService likeComicService, ILikeComicQueryService likeComicQueryService)
    {
        _likeComicCommandService = likeComicService;
        _likeComicQueryService = likeComicQueryService;
    }

    [HttpPost("createUpdate")]
    public IActionResult Create(LikeComicRequest request)
    {
        var likeComicResult = _likeComicCommandService.CreateUpdate(request.UserId, request.ComicId, request.Like, request.Title, request.Description, request.Thumbnail);

        if (likeComicResult.Result?.LikeComic != null)
        {
            var response = new LikeComicResponse(
                likeComicResult.Result.LikeComic.Id,
                likeComicResult.Result.LikeComic.UserId,
                likeComicResult.Result.LikeComic.ComicId,
                likeComicResult.Result.LikeComic.Thumbnail,
                likeComicResult.Result.LikeComic.Title,
                likeComicResult.Result.LikeComic.Description,
                likeComicResult.Result.LikeComic.Like
            );

            return Ok(response);

        }
        return NoContent();
    }



    [HttpGet("getListLikeComic/{UserId}")]
    public IActionResult getListLikeComic([FromRoute] string UserId)
    {
        var list = _likeComicQueryService.getListLikeComic(UserId);

        return Ok(list);
    }
}