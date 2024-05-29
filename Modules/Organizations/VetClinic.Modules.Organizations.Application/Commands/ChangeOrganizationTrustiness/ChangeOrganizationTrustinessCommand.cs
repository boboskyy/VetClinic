using MediatR;
using VetClinic.Modules.Organizations.Domain.Enums;

namespace VetClinic.Modules.Organizations.Application.Commands.ChangeOrganizationTrustiness;

public class ChangeOrganizationTrustinessCommand : IRequest
{
    public Guid OrganizationId { get; set; }
    public Trustiness Trustiness { get; set; }
}