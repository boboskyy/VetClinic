using MediatR;
using VetClinic.Modules.Organizations.Application.Exceptions;
using VetClinic.Modules.Organizations.Application.Repositories;

namespace VetClinic.Modules.Organizations.Application.Commands.DeleteOrganization;

public class DeleteOrganizationHandler : IRequestHandler<DeleteOrganizationCommand>
{
    private readonly IOrganizationRepository _organizationRepository;
    
    public DeleteOrganizationHandler(IOrganizationRepository organizationRepository)
    {
        _organizationRepository = organizationRepository;
    }
    
    public async Task Handle(DeleteOrganizationCommand request, CancellationToken cancellationToken)
    {
        var organization = await _organizationRepository.GetAsync(request.OrganizationId);
        if (organization is null)
            throw new OrganizationNotFoundException(request.OrganizationId);
        
        await _organizationRepository.DeleteAsync(organization);
    }
}