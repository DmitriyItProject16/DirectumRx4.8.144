namespace Sungero.RecordManagement.Structures.IncomingDocumentsProcessingReport
{
  [global::System.Serializable]
  public partial class Hyperlinks : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static Hyperlinks Create()
    {
      return new Hyperlinks();
    }

    public static Hyperlinks Create(global::System.Int64 docId, global::System.String hyperlink)
    {
      return new Hyperlinks
      {
        DocId = docId,
        Hyperlink = hyperlink
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.DocId.GetHashCode() * 199) ^ ((this.Hyperlink != null ? this.Hyperlink.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Hyperlinks)obj);
    }

    public static bool operator ==(Hyperlinks left, Hyperlinks right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(Hyperlinks left, Hyperlinks right)
    {
      return !(left == right);
    }

    protected bool Equals(Hyperlinks other)
    {
      return this.DocId == other.DocId
             && object.Equals(this.Hyperlink, other.Hyperlink) ;
    }

  }

  [global::System.Serializable]
  public partial class ViewDates : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ViewDates Create()
    {
      return new ViewDates();
    }

    public static ViewDates Create(global::System.Int64 assignmentId, global::System.DateTime viewDate)
    {
      return new ViewDates
      {
        AssignmentId = assignmentId,
        ViewDate = viewDate
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.AssignmentId.GetHashCode() * 199) ^ ((this.ViewDate != null ? this.ViewDate.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ViewDates)obj);
    }

    public static bool operator ==(ViewDates left, ViewDates right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ViewDates left, ViewDates right)
    {
      return !(left == right);
    }

    protected bool Equals(ViewDates other)
    {
      return this.AssignmentId == other.AssignmentId
             && object.Equals(this.ViewDate, other.ViewDate) ;
    }

  }
}