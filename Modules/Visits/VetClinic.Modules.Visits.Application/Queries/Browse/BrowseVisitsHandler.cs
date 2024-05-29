using MediatR;
using VetClinic.Modules.Visits.Application.Queries.GetVisitById.DTO;
using VetClinic.Modules.Visits.Application.Repositories;

namespace VetClinic.Modules.Visits.Application.Queries.Browse;

public class BrowseVisitsHandler : IRequestHandler<BrowseVisitsQuery, IEnumerable<VisitDto>>
{
    private readonly IVisitRepository _visitRepository;

    public BrowseVisitsHandler(IVisitRepository visitRepository)
    {
        _visitRepository = visitRepository;
    }
    
    public async Task<IEnumerable<VisitDto>> Handle(BrowseVisitsQuery request, CancellationToken cancellationToken)
    {
        var visits = await _visitRepository.GetAllVisits(cancellationToken);
        return visits.Select(visit => new VisitDto()
        {
            Id = visit.Id,
            Date = visit.Date,
            Owner = visit.Owner,
            PetAge = visit.PetAge,
            PetColor = visit.PetColor,
            PetName = visit.PetName
        });
    }
}