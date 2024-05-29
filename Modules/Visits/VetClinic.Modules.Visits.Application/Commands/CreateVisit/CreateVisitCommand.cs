using MediatR;
using VetClinic.Modules.Visits.Core.Enums;

namespace VetClinic.Modules.Visits.Application.Commands.CreateVisit;

public record CreateVisitCommand
(
    DateTimeOffset Date, string Owner, string PetName, int PetAge, PetColor PetColor
) : IRequest;