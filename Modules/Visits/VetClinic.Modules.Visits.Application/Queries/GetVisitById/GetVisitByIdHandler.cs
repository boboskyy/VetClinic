using MediatR;
using VetClinic.Modules.Visits.Application.Queries.GetVisitById.DTO;
using VetClinic.Modules.Visits.Application.Repositories;
using VetClinic.Modules.Visits.Core.Exceptions;

namespace VetClinic.Modules.Visits.Application.Queries.GetVisitById;

public class GetVisitByIdHandler : IRequestHandler<GetVisitByIdQuery, VisitDto>
{
    private readonly IVisitRepository _visitRepository;

    public GetVisitByIdHandler(IVisitRepository visitRepository)
    {
        _visitRepository = visitRepository;
    }
    
    public async Task<VisitDto> Handle(GetVisitByIdQuery request, CancellationToken cancellationToken)
    {
        var visit = await _visitRepository.GetByIdAsync(request.Id, cancellationToken);
        if (visit == null)
            throw new VisitNotFoundException(request.Id);

        return new VisitDto()
        {
            Id = visit.Id,
            Date = visit.Date,
            Owner = visit.Owner,
            PetAge = visit.PetAge,
            PetColor = visit.PetColor,
            PetName = visit.PetName
        };
    }
}