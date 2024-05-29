using VetClinic.Modules.Visits.Core.Enums;

namespace VetClinic.Modules.Visits.Application.Queries.GetVisitById.DTO;

public record VisitDto
{
  public Guid Id { get; init; }
  public DateTimeOffset Date  { get; init; }
  public string Owner { get; init; }
  public string PetName { get; init; }
  public int PetAge { get; init; }
  public PetColor PetColor;
}