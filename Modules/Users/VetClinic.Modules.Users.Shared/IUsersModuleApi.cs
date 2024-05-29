using VetClinic.Modules.Users.Shared.DTO;

namespace VetClinic.Modules.Users.Shared;
public interface IUsersModuleApi
{
    Task<UserDetailsDto> GetUserAsync(Guid userId);
    Task<UserDetailsDto> GetUserAsync(string email);
}

