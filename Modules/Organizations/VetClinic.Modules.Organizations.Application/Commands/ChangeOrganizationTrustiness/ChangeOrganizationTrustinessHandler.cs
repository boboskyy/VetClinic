using MediatR;
using VetClinic.Modules.Organizations.Application.Exceptions;
using VetClinic.Modules.Organizations.Application.Repositories;

namespace VetClinic.Modules.Organizations.Application.Commands.ChangeOrganizationTrustiness;

public class ChangeOrganizationTrustinessHandler : IRequestHandler<ChangeOrganizationTrustinessCommand>
{
    private readonly IOrganizationRepository _organizationRepository;
    
    public ChangeOrganizationTrustinessHandler(IOrganizationRepository organizationRepository)
    {
        _organizationRepository = organizationRepository;
    }
    
    public async Task Handle(ChangeOrganizationTrustinessCommand request, CancellationToken cancellationToken)
    {
        var organiation =  await _organizationRepository.GetAsync(request.OrganizationId);
        
        if (organiation == null)
        {
            throw new OrganizationNotFoundException(request.OrganizationId);
        }
        
        organiation.ChangeTrustiness(request.Trustiness);
        
        await _organizationRepository.UpdateAsync(organiation);
    }
}