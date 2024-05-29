using MediatR;
using VetClinic.Modules.Visits.Application.Repositories;
using VetClinic.Modules.Visits.Core.Exceptions;

namespace VetClinic.Modules.Visits.Application.Commands.ChangeVisit;

public class ChangeVisitHandler : IRequestHandler<ChangeVisitCommand>
{
    private readonly IVisitRepository _visitRepository;

    public ChangeVisitHandler(IVisitRepository visitRepository)
    {
        _visitRepository = visitRepository;
    }
    
    public async Task Handle(ChangeVisitCommand request, CancellationToken cancellationToken)
    {
        var visit =  await _visitRepository.GetByIdAsync(request.VisitId, cancellationToken);
        
        if (visit == null)
        {
            throw new VisitNotFoundException(request.VisitId);
        }
        
        visit.ChangeInformation(request.Date, request.Owner, request.PetName, request.PetAge, request.PetColor);
        
        await _visitRepository.CommitAsync(cancellationToken);
    }
}