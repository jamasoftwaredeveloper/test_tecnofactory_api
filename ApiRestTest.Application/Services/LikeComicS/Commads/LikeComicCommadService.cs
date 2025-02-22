namespace ApiRestTest.Application.Services.LikeComicS.Commads;
using ApiRestTest.Application.Common.Interfaces.Persistence;
using ApiRestTest.Application.Services.LikeComicS.Common;
using ApiRestTest.Domain.Entities;


public class LikeComicCommadService : ILikeComicCommadService
{

    private readonly ILikeComicRepository _likeComicRepository;

    public LikeComicCommadService(ILikeComicRepository userRepository)
    {
        _likeComicRepository = userRepository;
    }

    public async Task<LikedComicFirstResult?> CreateUpdate(string userId, int comicId, bool likeCurrent, string title, string? description, string thumbnail)
    {
        // Chequear que el usuario exista.

        if (await _likeComicRepository.GetLikeById(userId, comicId) is null)
        {
            // Crear un usuario.
            var like = new LikeComic
            {
                Like = likeCurrent,
                ComicId = comicId,
                UserId = userId,
                Title = title,
                Description = description,
                Thumbnail = thumbnail
            };
            // Generar un token
            await _likeComicRepository.Add(like);
            return new LikedComicFirstResult(
                 like
            );
        }

        await _likeComicRepository.Update(userId, comicId, likeCurrent);
        return null;

    }

}
