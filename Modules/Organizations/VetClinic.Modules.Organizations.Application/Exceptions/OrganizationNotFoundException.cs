using VetClinic.Shared.Exceptions;

namespace VetClinic.Modules.Organizations.Application.Exceptions;

public class OrganizationNotFoundException : VetClinicException
{
    public OrganizationNotFoundException(Guid id) : base($"Organization with id {id} not found")
    {
    }
}
