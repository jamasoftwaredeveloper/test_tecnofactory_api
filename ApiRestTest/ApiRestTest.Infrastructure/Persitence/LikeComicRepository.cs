using ApiRestTest.Application.Common.Interfaces.Persistence;
using ApiRestTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using MyApp.Infrastructure.Data;

namespace ApiRestTest.Infrastructure.Persitence;

public class LikeComicRepository : ILikeComicRepository
{
    private readonly AppDbContext _context;

    public LikeComicRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task Add(LikeComic like)
    {
        _context.LikeComics.Add(like);
        await _context.SaveChangesAsync();
    }

    public async Task Update(string userId, int comicId, bool liked)
    {
        var likeComitToUpdate = await _context.LikeComics.FirstOrDefaultAsync(item => item.UserId == userId && item.ComicId == comicId);
        if (likeComitToUpdate != null)
        {
            _context.LikeComics.Remove(likeComitToUpdate);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<LikeComic?> GetLikeById(string userId, int comicId)
    {
        return await _context.LikeComics.FirstOrDefaultAsync(like => like.UserId == userId && like.ComicId == comicId);
    }

    public async Task<List<LikeComic>> GetListLikeComic(string userId)
    {
        var list = await _context.LikeComics.Where(like => like.UserId == userId).ToListAsync();
        return list;
    }
}