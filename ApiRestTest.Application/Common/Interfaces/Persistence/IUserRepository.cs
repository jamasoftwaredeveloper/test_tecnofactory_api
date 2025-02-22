using ApiRestTest.Domain.Entities;

namespace ApiRestTest.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{

    Task<User?> GetUserByEmail(string email);
    Task Add(User user);

}