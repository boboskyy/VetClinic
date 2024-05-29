using MediatR;
using VetClinic.Modules.Visits.Application.Repositories;
using VetClinic.Modules.Visits.Core.Entities;

namespace VetClinic.Modules.Visits.Application.Commands.CreateVisit;

public class CreateVisitHandler : IRequestHandler<CreateVisitCommand>
{
    private readonly IVisitRepository _visitRepository;

    public CreateVisitHandler(IVisitRepository visitRepository)
    {
        _visitRepository = visitRepository;
    }

    public async Task Handle(CreateVisitCommand request, CancellationToken cancellationToken)
    {
        var allVisits = await _visitRepository.GetAllVisits(cancellationToken);
        
        // var canCreateVisit = allVisits
        //     .Any(x => x.Date >= request.Date && x.Date <= request.Date);
        //
        // if (!canCreateVisit)
        //     throw new Exception("Cant book visit cause there is already booked one");
            
            
        var newVisit = Visit.Create(request.Date, request.Owner, request.PetName, request.PetAge, request.PetColor);
        await _visitRepository.AddAsync(newVisit, cancellationToken);
    }
}