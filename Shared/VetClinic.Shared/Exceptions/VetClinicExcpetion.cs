namespace VetClinic.Shared.Exceptions;

public abstract class VetClinicException : Exception
{
    protected VetClinicException(string message) : base(message)
    {
    }
}
