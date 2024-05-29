using VetClinic.Modules.Visits.Core.Enums;
using VetClinic.Modules.Visits.Core.Types;

namespace VetClinic.Modules.Visits.Core.Entities;

public class Visit
{
    public VisitId Id { get; private set; }
    public DateTimeOffset Date { get; private set; }
    public string Owner { get; private set; }
    public string PetName { get; private set; }
    public int PetAge { get; private set; }
    public PetColor PetColor { get; private set; }
    
    private Visit(DateTimeOffset date, string owner, string petName, int petAge, PetColor petColor)
    {
        Id = new VisitId();
        Date = date;
        Owner = owner;
        PetName = petName;
        PetAge = petAge;
        this.PetColor = petColor;
    }

    public static Visit Create(DateTimeOffset date, string owner, string petName, int petAge, PetColor petColor)
    {
        return new Visit(date, owner, petName, petAge, petColor);
    }

    public void ChangeInformation(DateTimeOffset date, string owner, string petName, int petAge, PetColor petColor)
    {
        Date = date;
        Owner = owner;
        PetName = petName;
        PetAge = petAge;
        this.PetColor = petColor;
    }
}