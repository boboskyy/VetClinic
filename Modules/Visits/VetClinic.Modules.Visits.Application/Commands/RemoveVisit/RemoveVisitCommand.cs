using MediatR;

namespace VetClinic.Modules.Visits.Application.Commands.RemoveVisit;

public class RemoveVisitCommand(Guid VisitId) : IRequest;