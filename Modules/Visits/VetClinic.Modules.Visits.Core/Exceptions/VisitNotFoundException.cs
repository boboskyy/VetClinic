using VetClinic.Shared.Exceptions;

namespace VetClinic.Modules.Visits.Core.Exceptions;

public class VisitNotFoundException : VetClinicException
{
    public VisitNotFoundException(Guid id) : base("Visit with ID: " + id + " not found")
    {
    }
}