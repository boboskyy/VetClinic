using VetClinic.Shared.Exceptions;

namespace VetClinic.Modules.Users.Application.Exceptions;

public class UserAlreadyExistsException : VetClinicException
{
    public UserAlreadyExistsException(string user) : base($"User: '{user}' already exists.")
    {
    }
}

