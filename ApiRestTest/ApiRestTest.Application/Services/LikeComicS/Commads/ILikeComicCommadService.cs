using ApiRestTest.Domain.Entities;
using ApiRestTest.Application.Services.LikeComicS.Common;
namespace ApiRestTest.Application.Services.LikeComicS.Commads;

public interface ILikeComicCommadService
{
    Task<LikedComicFirstResult> CreateUpdate(string userId, int commicId, bool like, string title, string? description, string thumbnail);

}