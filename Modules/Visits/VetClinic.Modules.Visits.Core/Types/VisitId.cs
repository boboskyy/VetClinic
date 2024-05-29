namespace VetClinic.Modules.Visits.Core.Types;

public class VisitId : IEquatable<VisitId>
{
    public Guid Value { get; }

    public VisitId() : this(Guid.NewGuid())
    {
    }

    public VisitId(Guid value)
    {
        Value = value;
    }

    public bool Equals(VisitId other)
    {
        if (ReferenceEquals(null, other)) return false;
        return ReferenceEquals(this, other) || Value.Equals(other.Value);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((VisitId)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public static implicit operator VisitId(Guid value) => new(value);

    public static implicit operator Guid(VisitId value) => value.Value;
}