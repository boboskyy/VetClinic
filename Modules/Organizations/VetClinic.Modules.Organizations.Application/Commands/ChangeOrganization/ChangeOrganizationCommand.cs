using MediatR;
using VetClinic.Modules.Organizations.Domain.Enums;

namespace VetClinic.Modules.Organizations.Application.Commands.ChangeOrganization;

public class ChangeOrganizationCommand : IRequest
{
    public Guid OrganizationId { get; set; }
    public string Address { get; set; }
    public string Name { get; set; }
    public Trustiness Trustiness { get; set; }
}