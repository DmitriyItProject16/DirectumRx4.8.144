namespace Sungero.Docflow.Structures.SkippedNumbersReport
{
  [global::System.Serializable]
  public partial class SkippedNumber : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static SkippedNumber Create()
    {
      return new SkippedNumber();
    }

    public static SkippedNumber Create(global::System.String registrationNumber, global::System.String ordinalNumber, global::System.Int32 index, global::System.String reportSessionId)
    {
      return new SkippedNumber
      {
        RegistrationNumber = registrationNumber,
        OrdinalNumber = ordinalNumber,
        Index = index,
        ReportSessionId = reportSessionId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.RegistrationNumber != null ? this.RegistrationNumber.GetHashCode() : 0) * 199) ^ ((this.OrdinalNumber != null ? this.OrdinalNumber.GetHashCode() : 0) * 199) ^ (this.Index.GetHashCode() * 199) ^ ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((SkippedNumber)obj);
    }

    public static bool operator ==(SkippedNumber left, SkippedNumber right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(SkippedNumber left, SkippedNumber right)
    {
      return !(left == right);
    }

    protected bool Equals(SkippedNumber other)
    {
      return object.Equals(this.RegistrationNumber, other.RegistrationNumber) 
             && object.Equals(this.OrdinalNumber, other.OrdinalNumber) 
             && this.Index == other.Index
             && object.Equals(this.ReportSessionId, other.ReportSessionId) ;
    }

  }

  [global::System.Serializable]
  public partial class AvailableDocument : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static AvailableDocument Create()
    {
      return new AvailableDocument();
    }

    public static AvailableDocument Create(global::System.Int64 id, global::System.Boolean numberOnFormat, global::System.Boolean canRead, global::System.Boolean inCorrectOrder, global::System.String reportSessionId)
    {
      return new AvailableDocument
      {
        Id = id,
        NumberOnFormat = numberOnFormat,
        CanRead = canRead,
        InCorrectOrder = inCorrectOrder,
        ReportSessionId = reportSessionId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ (this.NumberOnFormat.GetHashCode() * 199) ^ (this.CanRead.GetHashCode() * 199) ^ (this.InCorrectOrder.GetHashCode() * 199) ^ ((this.ReportSessionId != null ? this.ReportSessionId.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((AvailableDocument)obj);
    }

    public static bool operator ==(AvailableDocument left, AvailableDocument right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(AvailableDocument left, AvailableDocument right)
    {
      return !(left == right);
    }

    protected bool Equals(AvailableDocument other)
    {
      return this.Id == other.Id
             && this.NumberOnFormat == other.NumberOnFormat
             && this.CanRead == other.CanRead
             && this.InCorrectOrder == other.InCorrectOrder
             && object.Equals(this.ReportSessionId, other.ReportSessionId) ;
    }

  }
}