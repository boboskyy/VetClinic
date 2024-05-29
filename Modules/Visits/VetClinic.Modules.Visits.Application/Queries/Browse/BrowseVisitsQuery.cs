using MediatR;
using VetClinic.Modules.Visits.Application.Queries.GetVisitById.DTO;

namespace VetClinic.Modules.Visits.Application.Queries.Browse;

public record BrowseVisitsQuery() : IRequest<IEnumerable<VisitDto>>;