namespace Sungero.Docflow.Structures.ApprovalTask
{
  [global::System.Serializable]
  public partial class SignatureValidationErrors : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static SignatureValidationErrors Create()
    {
      return new SignatureValidationErrors();
    }

    public static SignatureValidationErrors Create(global::System.Boolean isInvalidCertificate, global::System.Boolean isInvalidAttributes, global::System.Boolean isInvalidData)
    {
      return new SignatureValidationErrors
      {
        IsInvalidCertificate = isInvalidCertificate,
        IsInvalidAttributes = isInvalidAttributes,
        IsInvalidData = isInvalidData
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.IsInvalidCertificate.GetHashCode() * 199) ^ (this.IsInvalidAttributes.GetHashCode() * 199) ^ (this.IsInvalidData.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((SignatureValidationErrors)obj);
    }

    public static bool operator ==(SignatureValidationErrors left, SignatureValidationErrors right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(SignatureValidationErrors left, SignatureValidationErrors right)
    {
      return !(left == right);
    }

    protected bool Equals(SignatureValidationErrors other)
    {
      return this.IsInvalidCertificate == other.IsInvalidCertificate
             && this.IsInvalidAttributes == other.IsInvalidAttributes
             && this.IsInvalidData == other.IsInvalidData;
    }

  }

  [global::System.Serializable]
  public partial class ApprovalStatus : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ApprovalStatus Create()
    {
      return new ApprovalStatus();
    }

    public static ApprovalStatus Create(global::System.Boolean hasApprovalStage, global::System.Boolean needStrongSign)
    {
      return new ApprovalStatus
      {
        HasApprovalStage = hasApprovalStage,
        NeedStrongSign = needStrongSign
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.HasApprovalStage.GetHashCode() * 199) ^ (this.NeedStrongSign.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ApprovalStatus)obj);
    }

    public static bool operator ==(ApprovalStatus left, ApprovalStatus right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ApprovalStatus left, ApprovalStatus right)
    {
      return !(left == right);
    }

    protected bool Equals(ApprovalStatus other)
    {
      return this.HasApprovalStage == other.HasApprovalStage
             && this.NeedStrongSign == other.NeedStrongSign;
    }

  }

  [global::System.Serializable]
  public partial class StateViewAssignmentInfo : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static StateViewAssignmentInfo Create()
    {
      return new StateViewAssignmentInfo();
    }

    public static StateViewAssignmentInfo Create(global::System.String performerShortName, global::System.String deadline, global::System.String status)
    {
      return new StateViewAssignmentInfo
      {
        PerformerShortName = performerShortName,
        Deadline = deadline,
        Status = status
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.PerformerShortName != null ? this.PerformerShortName.GetHashCode() : 0) * 199) ^ ((this.Deadline != null ? this.Deadline.GetHashCode() : 0) * 199) ^ ((this.Status != null ? this.Status.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((StateViewAssignmentInfo)obj);
    }

    public static bool operator ==(StateViewAssignmentInfo left, StateViewAssignmentInfo right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(StateViewAssignmentInfo left, StateViewAssignmentInfo right)
    {
      return !(left == right);
    }

    protected bool Equals(StateViewAssignmentInfo other)
    {
      return object.Equals(this.PerformerShortName, other.PerformerShortName) 
             && object.Equals(this.Deadline, other.Deadline) 
             && object.Equals(this.Status, other.Status) ;
    }

  }

  public partial class Substitution : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static Substitution Create()
    {
      return new Substitution();
    }

    public static Substitution Create(global::Sungero.CoreEntities.IRecipient user, global::Sungero.CoreEntities.IRecipient substitutedUser)
    {
      return new Substitution
      {
        User = user,
        SubstitutedUser = substitutedUser
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.User != null ? this.User.GetHashCode() : 0) * 199) ^ ((this.SubstitutedUser != null ? this.SubstitutedUser.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Substitution)obj);
    }

    public static bool operator ==(Substitution left, Substitution right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(Substitution left, Substitution right)
    {
      return !(left == right);
    }

    protected bool Equals(Substitution other)
    {
      return object.Equals(this.User, other.User) 
             && object.Equals(this.SubstitutedUser, other.SubstitutedUser) ;
    }

  }

  [global::System.Serializable]
  public partial class BeforeSign : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static BeforeSign Create()
    {
      return new BeforeSign();
    }

    public static BeforeSign Create(global::System.Collections.Generic.List<global::System.String> errors, global::System.Boolean canApprove, global::System.Boolean documentBodyChanged)
    {
      return new BeforeSign
      {
        Errors = errors,
        CanApprove = canApprove,
        DocumentBodyChanged = documentBodyChanged
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Errors != null ? this.Errors.GetHashCode() : 0) * 199) ^ (this.CanApprove.GetHashCode() * 199) ^ (this.DocumentBodyChanged.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((BeforeSign)obj);
    }

    public static bool operator ==(BeforeSign left, BeforeSign right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(BeforeSign left, BeforeSign right)
    {
      return !(left == right);
    }

    protected bool Equals(BeforeSign other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Errors, other.Errors)
             && this.CanApprove == other.CanApprove
             && this.DocumentBodyChanged == other.DocumentBodyChanged;
    }

  }

  public partial class ExchangeServies : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static ExchangeServies Create()
    {
      return new ExchangeServies();
    }

    public static ExchangeServies Create(global::System.Collections.Generic.List<global::Sungero.ExchangeCore.IExchangeService> services, global::Sungero.ExchangeCore.IExchangeService defaultService)
    {
      return new ExchangeServies
      {
        Services = services,
        DefaultService = defaultService
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Services != null ? this.Services.GetHashCode() : 0) * 199) ^ ((this.DefaultService != null ? this.DefaultService.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExchangeServies)obj);
    }

    public static bool operator ==(ExchangeServies left, ExchangeServies right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExchangeServies left, ExchangeServies right)
    {
      return !(left == right);
    }

    protected bool Equals(ExchangeServies other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.Services, other.Services)
             && object.Equals(this.DefaultService, other.DefaultService) ;
    }

  }

  [global::System.Serializable]
  public partial class RefreshParameters : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static RefreshParameters Create()
    {
      return new RefreshParameters();
    }

    public static RefreshParameters Create(global::System.Boolean hasDocumentAndCanRead, global::System.Boolean forwardPerformerIsVisible, global::System.Boolean signatoryIsVisible, global::System.Boolean signatoryIsRequired, global::System.Boolean addresseeIsEnabled, global::System.Boolean addresseeIsVisible, global::System.Boolean addresseeIsRequired, global::System.Boolean addresseesIsEnabled, global::System.Boolean addresseesIsVisible, global::System.Boolean addresseesIsRequired, global::System.Boolean deliveryMethodIsEnabled, global::System.Boolean deliveryMethodIsVisible, global::System.Boolean exchangeServiceIsEnabled, global::System.Boolean exchangeServiceIsVisible, global::System.Boolean exchangeServiceIsRequired, global::System.Boolean approversActionIsEnabled, global::System.Boolean approversIsVisible, global::System.Boolean addApproversIsVisible)
    {
      return new RefreshParameters
      {
        HasDocumentAndCanRead = hasDocumentAndCanRead,
        ForwardPerformerIsVisible = forwardPerformerIsVisible,
        SignatoryIsVisible = signatoryIsVisible,
        SignatoryIsRequired = signatoryIsRequired,
        AddresseeIsEnabled = addresseeIsEnabled,
        AddresseeIsVisible = addresseeIsVisible,
        AddresseeIsRequired = addresseeIsRequired,
        AddresseesIsEnabled = addresseesIsEnabled,
        AddresseesIsVisible = addresseesIsVisible,
        AddresseesIsRequired = addresseesIsRequired,
        DeliveryMethodIsEnabled = deliveryMethodIsEnabled,
        DeliveryMethodIsVisible = deliveryMethodIsVisible,
        ExchangeServiceIsEnabled = exchangeServiceIsEnabled,
        ExchangeServiceIsVisible = exchangeServiceIsVisible,
        ExchangeServiceIsRequired = exchangeServiceIsRequired,
        ApproversActionIsEnabled = approversActionIsEnabled,
        ApproversIsVisible = approversIsVisible,
        AddApproversIsVisible = addApproversIsVisible
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.HasDocumentAndCanRead.GetHashCode() * 199) ^ (this.ForwardPerformerIsVisible.GetHashCode() * 199) ^ (this.SignatoryIsVisible.GetHashCode() * 199) ^ (this.SignatoryIsRequired.GetHashCode() * 199) ^ (this.AddresseeIsEnabled.GetHashCode() * 199) ^ (this.AddresseeIsVisible.GetHashCode() * 199) ^ (this.AddresseeIsRequired.GetHashCode() * 199) ^ (this.AddresseesIsEnabled.GetHashCode() * 199) ^ (this.AddresseesIsVisible.GetHashCode() * 199) ^ (this.AddresseesIsRequired.GetHashCode() * 199) ^ (this.DeliveryMethodIsEnabled.GetHashCode() * 199) ^ (this.DeliveryMethodIsVisible.GetHashCode() * 199) ^ (this.ExchangeServiceIsEnabled.GetHashCode() * 199) ^ (this.ExchangeServiceIsVisible.GetHashCode() * 199) ^ (this.ExchangeServiceIsRequired.GetHashCode() * 199) ^ (this.ApproversActionIsEnabled.GetHashCode() * 199) ^ (this.ApproversIsVisible.GetHashCode() * 199) ^ (this.AddApproversIsVisible.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((RefreshParameters)obj);
    }

    public static bool operator ==(RefreshParameters left, RefreshParameters right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(RefreshParameters left, RefreshParameters right)
    {
      return !(left == right);
    }

    protected bool Equals(RefreshParameters other)
    {
      return this.HasDocumentAndCanRead == other.HasDocumentAndCanRead
             && this.ForwardPerformerIsVisible == other.ForwardPerformerIsVisible
             && this.SignatoryIsVisible == other.SignatoryIsVisible
             && this.SignatoryIsRequired == other.SignatoryIsRequired
             && this.AddresseeIsEnabled == other.AddresseeIsEnabled
             && this.AddresseeIsVisible == other.AddresseeIsVisible
             && this.AddresseeIsRequired == other.AddresseeIsRequired
             && this.AddresseesIsEnabled == other.AddresseesIsEnabled
             && this.AddresseesIsVisible == other.AddresseesIsVisible
             && this.AddresseesIsRequired == other.AddresseesIsRequired
             && this.DeliveryMethodIsEnabled == other.DeliveryMethodIsEnabled
             && this.DeliveryMethodIsVisible == other.DeliveryMethodIsVisible
             && this.ExchangeServiceIsEnabled == other.ExchangeServiceIsEnabled
             && this.ExchangeServiceIsVisible == other.ExchangeServiceIsVisible
             && this.ExchangeServiceIsRequired == other.ExchangeServiceIsRequired
             && this.ApproversActionIsEnabled == other.ApproversActionIsEnabled
             && this.ApproversIsVisible == other.ApproversIsVisible
             && this.AddApproversIsVisible == other.AddApproversIsVisible;
    }

  }

  [global::System.Serializable]
  public partial class ReworkParameters : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ReworkParameters Create()
    {
      return new ReworkParameters();
    }

    public static ReworkParameters Create(global::System.Boolean allowChangeReworkPerformer, global::System.Boolean allowViewReworkPerformer, global::System.Boolean allowSendToRework)
    {
      return new ReworkParameters
      {
        AllowChangeReworkPerformer = allowChangeReworkPerformer,
        AllowViewReworkPerformer = allowViewReworkPerformer,
        AllowSendToRework = allowSendToRework
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.AllowChangeReworkPerformer.GetHashCode() * 199) ^ (this.AllowViewReworkPerformer.GetHashCode() * 199) ^ (this.AllowSendToRework.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ReworkParameters)obj);
    }

    public static bool operator ==(ReworkParameters left, ReworkParameters right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ReworkParameters left, ReworkParameters right)
    {
      return !(left == right);
    }

    protected bool Equals(ReworkParameters other)
    {
      return this.AllowChangeReworkPerformer == other.AllowChangeReworkPerformer
             && this.AllowViewReworkPerformer == other.AllowViewReworkPerformer
             && this.AllowSendToRework == other.AllowSendToRework;
    }

  }
}