using MediatR;
using VetClinic.Modules.Organizations.Application.DTO;
using VetClinic.Modules.Organizations.Application.Queries.GetByAddressList.DTO;
using VetClinic.Modules.Organizations.Application.Repositories;

namespace VetClinic.Modules.Organizations.Application.Queries.GetByAddressList;

public class GetByAddressListHandler
: IRequestHandler<GetByAddressListQuery, GetByAddressListDto>
{
    private readonly IOrganizationRepository _organizationRepository;
    
    public GetByAddressListHandler(IOrganizationRepository organizationRepository)
    {
        _organizationRepository = organizationRepository;
    }
    
    public async Task<GetByAddressListDto> Handle(GetByAddressListQuery request, CancellationToken cancellationToken)
    {
        var organizations = await _organizationRepository.GetByAddressList(request.Addresses);
        
        return organizations.AsGetByAddressListDto();
    }
}