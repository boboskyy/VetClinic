using Microsoft.EntityFrameworkCore;
using VetClinic.Modules.Users.Application.Interfaces.Authentication;
using VetClinic.Modules.Users.Domain.Entities;
using VetClinic.Shared.Initializer;

namespace VetClinic.Modules.Users.Infrastructure.DAL.Initializers;

internal class UserInitializer : IInitializer
{
    private readonly UsersDbContext _context;
    private readonly IPasswordHasher _passwordHasher;

    public UserInitializer(UsersDbContext context, IPasswordHasher passwordHasher)
    {
        _context = context;
        _passwordHasher = passwordHasher;
    }
    
    public async Task InitAsync()
    {
        var count = await _context.Users.CountAsync();

        if (count == 0)
        {
            User user = User.CreateUser("admin@VetClinic.com", _passwordHasher.Create("admin"));
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}