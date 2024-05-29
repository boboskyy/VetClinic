using VetClinic.Modules.Organizations.Application.Queries.DTO;

namespace VetClinic.Modules.Organizations.Application.Queries.Browse.DTO;

public record BrowseOrganizationsDto
(
    IEnumerable<OrganizationDto> Organizations
);