using MediatR;
using VetClinic.Modules.Visits.Core.Enums;

namespace VetClinic.Modules.Visits.Application.Commands.ChangeVisit;

public class ChangeVisitCommand : IRequest
{
    public Guid VisitId { get; set; }
    public DateTimeOffset Date { get; set; }
    public string Owner { get; set; }
    public string PetName { get; set; }
    public int PetAge { get; set; }
    public PetColor PetColor { get; set; }
}