using VetClinic.Modules.Organizations.Application.Queries.DTO;

namespace VetClinic.Modules.Organizations.Application.Queries.GetByAddressList.DTO;

public record GetByAddressListDto(
        IEnumerable<PublicOrganizationDto> Organizations
    );