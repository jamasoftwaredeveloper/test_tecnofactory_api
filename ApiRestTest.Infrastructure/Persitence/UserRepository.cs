using ApiRestTest.Application.Common.Interfaces.Persistence;
using ApiRestTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using MyApp.Infrastructure.Data;

namespace ApiRestTest.Infrastructure.Persitence;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task Add(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User?> GetUserByEmail(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }
}