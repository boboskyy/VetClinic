using VetClinic.Shared.Exceptions;

namespace VetClinic.Modules.Organizations.Application.Exceptions;

public class OrganizationAddressTakenException : VetClinicException
{
    public OrganizationAddressTakenException(string address) : base($"Organization with address {address} already exists")
    {
    }
}
