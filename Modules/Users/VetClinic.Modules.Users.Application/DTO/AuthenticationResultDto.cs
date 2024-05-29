using VetClinic.Modules.Users.Shared.DTO;

namespace VetClinic.Modules.Users.Application.DTO;

public record AuthenticationResultDto(
    UserDto User,
    string Token
);
