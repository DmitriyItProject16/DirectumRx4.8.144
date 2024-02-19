namespace Sungero.Docflow.Structures.AccountingDocumentBase
{
  [global::System.Serializable]
  public partial class GenerateTitleError : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static GenerateTitleError Create()
    {
      return new GenerateTitleError();
    }

    public static GenerateTitleError Create(global::System.String type, global::System.String text)
    {
      return new GenerateTitleError
      {
        Type = type,
        Text = text
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Type != null ? this.Type.GetHashCode() : 0) * 199) ^ ((this.Text != null ? this.Text.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((GenerateTitleError)obj);
    }

    public static bool operator ==(GenerateTitleError left, GenerateTitleError right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(GenerateTitleError left, GenerateTitleError right)
    {
      return !(left == right);
    }

    protected bool Equals(GenerateTitleError other)
    {
      return object.Equals(this.Type, other.Type) 
             && object.Equals(this.Text, other.Text) ;
    }

  }
}