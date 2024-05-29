using VetClinic.Shared.Exceptions;

namespace VetClinic.Modules.Users.Application.Exceptions;

public class UserNotFoundException : VetClinicException
{
    public UserNotFoundException(Guid userId) : base($"User with id: '{userId}' was not found.")
    {
    }
}