
using VetClinic.Modules.Users.Domain.Entities;
using VetClinic.Modules.Users.Domain.ValueObjects;

namespace VetClinic.Modules.Users.Application.Repositories;

public interface IUserRepository
{
    Task<User> GetAsync(UserId id);
    Task<User> GetUserByEmail(string email);
    Task AddAsync(User user);
    Task UpdateAsync(User user);
}

