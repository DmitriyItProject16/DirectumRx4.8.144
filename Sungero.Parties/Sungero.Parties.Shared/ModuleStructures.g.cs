namespace Sungero.Parties.Structures.Module
{
  public partial class CounterpartyFromExchangeService : global::Sungero.Domain.Shared.IEntityAppliedStructure
  {

    public static CounterpartyFromExchangeService Create()
    {
      return new CounterpartyFromExchangeService();
    }

    public static CounterpartyFromExchangeService Create(global::System.String name, global::System.String tIN, global::System.String tRRC, global::Sungero.ExchangeCore.IBusinessUnitBox box, global::Sungero.Parties.ICounterparty counterparty, global::System.Nullable<global::Sungero.Core.Enumeration> exchangeStatus, global::System.String organizationId)
    {
      return new CounterpartyFromExchangeService
      {
        Name = name,
        TIN = tIN,
        TRRC = tRRC,
        Box = box,
        Counterparty = counterparty,
        ExchangeStatus = exchangeStatus,
        OrganizationId = organizationId
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Name != null ? this.Name.GetHashCode() : 0) * 199) ^ ((this.TIN != null ? this.TIN.GetHashCode() : 0) * 199) ^ ((this.TRRC != null ? this.TRRC.GetHashCode() : 0) * 199) ^ ((this.Box != null ? this.Box.GetHashCode() : 0) * 199) ^ ((this.Counterparty != null ? this.Counterparty.GetHashCode() : 0) * 199) ^ ((this.ExchangeStatus != null ? this.ExchangeStatus.GetHashCode() : 0) * 199) ^ ((this.OrganizationId != null ? this.OrganizationId.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((CounterpartyFromExchangeService)obj);
    }

    public static bool operator ==(CounterpartyFromExchangeService left, CounterpartyFromExchangeService right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(CounterpartyFromExchangeService left, CounterpartyFromExchangeService right)
    {
      return !(left == right);
    }

    protected bool Equals(CounterpartyFromExchangeService other)
    {
      return object.Equals(this.Name, other.Name) 
             && object.Equals(this.TIN, other.TIN) 
             && object.Equals(this.TRRC, other.TRRC) 
             && object.Equals(this.Box, other.Box) 
             && object.Equals(this.Counterparty, other.Counterparty) 
             && object.Equals(this.ExchangeStatus, other.ExchangeStatus) 
             && object.Equals(this.OrganizationId, other.OrganizationId) ;
    }

  }
}