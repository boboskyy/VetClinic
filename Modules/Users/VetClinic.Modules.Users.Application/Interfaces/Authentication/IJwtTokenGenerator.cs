using VetClinic.Modules.Users.Domain.Entities;

namespace VetClinic.Modules.Users.Application.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}

