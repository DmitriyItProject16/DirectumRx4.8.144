namespace Sungero.Docflow.Structures.SmartProcessingSetting
{
  [global::System.Serializable]
  public partial class ClassifierForDialog : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ClassifierForDialog Create()
    {
      return new ClassifierForDialog();
    }

    public static ClassifierForDialog Create(global::System.Int32 id, global::System.String name)
    {
      return new ClassifierForDialog
      {
        Id = id,
        Name = name
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.Id.GetHashCode() * 199) ^ ((this.Name != null ? this.Name.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ClassifierForDialog)obj);
    }

    public static bool operator ==(ClassifierForDialog left, ClassifierForDialog right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ClassifierForDialog left, ClassifierForDialog right)
    {
      return !(left == right);
    }

    protected bool Equals(ClassifierForDialog other)
    {
      return this.Id == other.Id
             && object.Equals(this.Name, other.Name) ;
    }

  }

  [global::System.Serializable]
  public partial class SettingsValidationMessage : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static SettingsValidationMessage Create()
    {
      return new SettingsValidationMessage();
    }

    public static SettingsValidationMessage Create(global::System.String type, global::System.String text)
    {
      return new SettingsValidationMessage
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
      return Equals((SettingsValidationMessage)obj);
    }

    public static bool operator ==(SettingsValidationMessage left, SettingsValidationMessage right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(SettingsValidationMessage left, SettingsValidationMessage right)
    {
      return !(left == right);
    }

    protected bool Equals(SettingsValidationMessage other)
    {
      return object.Equals(this.Type, other.Type) 
             && object.Equals(this.Text, other.Text) ;
    }

  }

  [global::System.Serializable]
  public partial class LoginResult : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static LoginResult Create()
    {
      return new LoginResult();
    }

    public static LoginResult Create(global::System.String encryptedPassword, global::System.String error)
    {
      return new LoginResult
      {
        EncryptedPassword = encryptedPassword,
        Error = error
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.EncryptedPassword != null ? this.EncryptedPassword.GetHashCode() : 0) * 199) ^ ((this.Error != null ? this.Error.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((LoginResult)obj);
    }

    public static bool operator ==(LoginResult left, LoginResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(LoginResult left, LoginResult right)
    {
      return !(left == right);
    }

    protected bool Equals(LoginResult other)
    {
      return object.Equals(this.EncryptedPassword, other.EncryptedPassword) 
             && object.Equals(this.Error, other.Error) ;
    }

  }
}