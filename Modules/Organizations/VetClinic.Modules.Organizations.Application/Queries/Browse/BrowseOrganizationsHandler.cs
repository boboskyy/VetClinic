using MediatR;
using VetClinic.Modules.Organizations.Application.DTO;
using VetClinic.Modules.Organizations.Application.Queries.Browse.DTO;
using VetClinic.Modules.Organizations.Application.Repositories;

namespace VetClinic.Modules.Organizations.Application.Queries.Browse;

public class BrowseOrganizationsHandler
: IRequestHandler<BrowseOrganizationsQuery, BrowseOrganizationsDto>
{
    private readonly IOrganizationRepository _organizationRepository;
    
    public BrowseOrganizationsHandler(IOrganizationRepository organizationRepository)
    {
        _organizationRepository = organizationRepository;
    }
    
    public async Task<BrowseOrganizationsDto> Handle(BrowseOrganizationsQuery request, CancellationToken cancellationToken)
    {
        var organizations = await _organizationRepository.BrowseAsync();
        
        if(request.Search != null)
            organizations = organizations.Where(x => x.Name.Contains(request.Search));

        return organizations.AsBrowseOrganizationsDto();
    }
}