using MediatR;
using VetClinic.Modules.Organizations.Application.Queries.Browse.DTO;

namespace VetClinic.Modules.Organizations.Application.Queries.Browse;

public record BrowseOrganizationsQuery(string? Search) : IRequest<BrowseOrganizationsDto>;