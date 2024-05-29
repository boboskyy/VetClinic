using MediatR;
using VetClinic.Modules.Organizations.Domain.Enums;

namespace VetClinic.Modules.Organizations.Application.Commands.CreateOrganization;

public record CreateOrganizationCommand
(
    string Address,
    string Name,
    Trustiness Trustiness
) : IRequest;