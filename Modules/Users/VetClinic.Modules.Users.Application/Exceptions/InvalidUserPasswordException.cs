using VetClinic.Shared.Exceptions;

namespace VetClinic.Modules.Users.Application.Exceptions;

public class InvalidUserPasswordException : VetClinicException
{
    public InvalidUserPasswordException(string username) : base($"Username {username} provided invalid password")
    {
    }
}

