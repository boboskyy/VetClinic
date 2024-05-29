using MediatR;

namespace VetClinic.Modules.Organizations.Application.Commands.DeleteOrganization;

public class DeleteOrganizationCommand : IRequest
{
    public Guid OrganizationId { get; set; }
}