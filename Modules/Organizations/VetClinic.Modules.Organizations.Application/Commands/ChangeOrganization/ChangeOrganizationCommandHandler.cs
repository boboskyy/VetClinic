﻿using MediatR;
using VetClinic.Modules.Organizations.Application.Exceptions;
using VetClinic.Modules.Organizations.Application.Repositories;

namespace VetClinic.Modules.Organizations.Application.Commands.ChangeOrganization;

public class ChangeOrganizationCommandHandler : IRequestHandler<ChangeOrganizationCommand>
{
    private readonly IOrganizationRepository _organizationRepository;

    public ChangeOrganizationCommandHandler(IOrganizationRepository organizationRepository)
    {
        _organizationRepository = organizationRepository;
    }

    public async Task Handle(ChangeOrganizationCommand request, CancellationToken cancellationToken)
    {
        var organiation =  await _organizationRepository.GetAsync(request.OrganizationId);
        
        if (organiation == null)
        {
            throw new OrganizationNotFoundException(request.OrganizationId);
        }
        
        organiation.ChangeOrganization(request.Name, request.Address, request.Trustiness);
        
        await _organizationRepository.UpdateAsync(organiation);
    }
}