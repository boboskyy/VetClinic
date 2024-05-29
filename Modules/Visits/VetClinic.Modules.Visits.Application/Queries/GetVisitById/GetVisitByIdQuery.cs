using MediatR;
using VetClinic.Modules.Visits.Application.Queries.GetVisitById.DTO;

namespace VetClinic.Modules.Visits.Application.Queries.GetVisitById;

public record GetVisitByIdQuery : IRequest<VisitDto>
{
    public Guid Id { get; set; }
}