namespace Sungero.Docflow.Structures.ExchangeOrderReport
{
  [global::System.Serializable]
  public partial class ExchangeOrderFullData : global::Sungero.Domain.Shared.ISimpleAppliedStructure
  {

    public static ExchangeOrderFullData Create()
    {
      return new ExchangeOrderFullData();
    }

    public static ExchangeOrderFullData Create(global::System.Collections.Generic.List<global::Sungero.Docflow.Structures.ExchangeOrderReport.IExchangeOrderInfo> exchangeOrderInfo, global::System.Boolean isComplete, global::System.Boolean isReceiptNotifications, global::System.Boolean isSignOrAnnulment, global::System.Boolean isReceipt)
    {
      return new ExchangeOrderFullData
      {
        ExchangeOrderInfo = exchangeOrderInfo,
        IsComplete = isComplete,
        IsReceiptNotifications = isReceiptNotifications,
        IsSignOrAnnulment = isSignOrAnnulment,
        IsReceipt = isReceipt
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.ExchangeOrderInfo != null ? this.ExchangeOrderInfo.GetHashCode() : 0) * 199) ^ (this.IsComplete.GetHashCode() * 199) ^ (this.IsReceiptNotifications.GetHashCode() * 199) ^ (this.IsSignOrAnnulment.GetHashCode() * 199) ^ (this.IsReceipt.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((ExchangeOrderFullData)obj);
    }

    public static bool operator ==(ExchangeOrderFullData left, ExchangeOrderFullData right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(ExchangeOrderFullData left, ExchangeOrderFullData right)
    {
      return !(left == right);
    }

    protected bool Equals(ExchangeOrderFullData other)
    {
      return global::System.Linq.Enumerable.SequenceEqual(this.ExchangeOrderInfo, other.ExchangeOrderInfo)
             && this.IsComplete == other.IsComplete
             && this.IsReceiptNotifications == other.IsReceiptNotifications
             && this.IsSignOrAnnulment == other.IsSignOrAnnulment
             && this.IsReceipt == other.IsReceipt;
    }

  }
}