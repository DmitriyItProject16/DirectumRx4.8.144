
// ==================================================================
// VisibilityRuleRecipients.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Server
{
  public class VisibilityRuleRecipientsFilterForRecipient<TQueryEntity, TSourceEntity, TRootEntity>
    : global::Sungero.Domain.ChildEntityPropertyFilterBase<TQueryEntity, TSourceEntity, TRootEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
    where TSourceEntity : class, global::Sungero.Company.IVisibilityRuleRecipients
    where TRootEntity : class, global::Sungero.Company.IVisibilityRule
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, TSourceEntity sourceEntity, TRootEntity rootEntity)
    {
      var args = new global::Sungero.Domain.PropertyFilteringEventArgs(sourceEntity);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.VisibilityRuleRecipientsRecipientPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType, new object[] { sourceEntity, rootEntity });
        var methodInfo = genericType.GetMethod("RecipientsRecipientFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Company.VisibilityRuleRecipientsRecipientPropertyFilteringServerHandler<TQueryEntity>(sourceEntity, rootEntity).RecipientsRecipientFiltering(query, args);
      }
      if (args.DisableUiFiltering)
        global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public VisibilityRuleRecipientsFilterForRecipient(string propertyName)
      : base(propertyName)
    {
    }
  }

  public class VisibilityRuleRecipientsSearchFilterForRecipient<TQueryEntity>
    : global::Sungero.Domain.SearchDialogPropertyFilter<TQueryEntity>
    where TQueryEntity : class, global::Sungero.CoreEntities.IRecipient
  {
    protected override global::System.Linq.IQueryable<TQueryEntity> ApplyAppliedFilter(global::System.Linq.IQueryable<TQueryEntity> query, System.Guid entityType)
    {
      var args = new global::Sungero.Domain.PropertySearchDialogFilteringEventArgs(entityType);
      global::System.Linq.IQueryable<TQueryEntity> result;
      var filterType = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.VisibilityRuleRecipientsRecipientSearchPropertyFilteringServerHandler`1");
      if (filterType != null)
      {
        var genericType = filterType.MakeGenericType(typeof(TQueryEntity));
        var instance = global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(genericType);
        var methodInfo = genericType.GetMethod("RecipientsRecipientSearchDialogFiltering");
        result = (global::System.Linq.IQueryable<TQueryEntity>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(methodInfo, instance, new object[] { query, args });
      }
      else
      {
        result = new global::Sungero.Company.VisibilityRuleRecipientsRecipientSearchPropertyFilteringServerHandler<TQueryEntity>().RecipientsRecipientSearchDialogFiltering(query, args);
      }
      if (args.DisableUiFiltering)
          global::Sungero.Domain.UiFilteringEventManagementScope.DisableEvent<TQueryEntity>();
      return result;
    }

    public VisibilityRuleRecipientsSearchFilterForRecipient(string propertyName)
      : base(propertyName)
    {
    }
  }



  [global::Sungero.Domain.PropertyFilter(typeof(global::Sungero.Company.Server.VisibilityRuleRecipientsFilterForRecipient<global::Sungero.CoreEntities.IRecipient, global::Sungero.Company.IVisibilityRuleRecipients, global::Sungero.Company.IVisibilityRule>), "Recipient")]
  [global::Sungero.Domain.SearchPropertyFilter(typeof(global::Sungero.Company.Server.VisibilityRuleRecipientsSearchFilterForRecipient<global::Sungero.CoreEntities.IRecipient>), "Recipient")]


  public class VisibilityRuleRecipients :
    global::Sungero.Domain.ChildEntity, global::Sungero.Company.IVisibilityRuleRecipients
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("356ea70e-0e49-40e9-8eb2-4ea73e030539");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Company.Server.VisibilityRuleRecipients.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Company.IVisibilityRuleRecipients, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.Company.IVisibilityRuleRecipientsState State
    {
      get { return (global::Sungero.Company.IVisibilityRuleRecipientsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Company.Shared.VisibilityRuleRecipientsState(this);
    }

    public new virtual global::Sungero.Company.IVisibilityRuleRecipientsInfo Info
    {
      get { return (global::Sungero.Company.IVisibilityRuleRecipientsInfo)base.Info; }
    }


    public global::Sungero.Company.IVisibilityRule VisibilityRule { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.VisibilityRule; }
      set { this.VisibilityRule = (global::Sungero.Company.IVisibilityRule)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Company.VisibilityRuleRecipientsSharedHandlers(this);
    }







    private global::Sungero.CoreEntities.IRecipient _Recipient;
    public virtual global::Sungero.CoreEntities.IRecipient Recipient
    {
      get
      {
        return this._Recipient;
      }

      set
      {
        this.SetPropertyValue("Recipient", this._Recipient, value, (propertyValue) => { this._Recipient = propertyValue; }, this.RecipientChangedHandler);
      }
    }




    #region Framework events

    protected void RecipientChangedHandler()
    {
      var args = new global::Sungero.Company.Shared.VisibilityRuleRecipientsRecipientChangedEventArgs(this.State.Properties.Recipient, this.Recipient, this);
     ((global::Sungero.Company.IVisibilityRuleRecipientsSharedHandlers)this.SharedHandlers).RecipientsRecipientChanged(args);
    }



    #endregion


    public VisibilityRuleRecipients()
    {
    }

  }
}

// ==================================================================
// VisibilityRuleRecipientsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company
{
  public partial class VisibilityRuleRecipientsRecipientPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.ChildEntityPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {
    private global::Sungero.Company.IVisibilityRuleRecipients _obj
    {
      get { return (global::Sungero.Company.IVisibilityRuleRecipients)this.Entity; }
    }

    private global::Sungero.Company.IVisibilityRule _root
    {
      get { return (global::Sungero.Company.IVisibilityRule)this.Root; }
    }

    public VisibilityRuleRecipientsRecipientPropertyFilteringServerHandler(global::Sungero.Company.IVisibilityRuleRecipients entity, global::Sungero.Company.IVisibilityRule root)
      : base(entity, root)
    {
    }
  }

  public partial class VisibilityRuleRecipientsRecipientSearchPropertyFilteringServerHandler<T>
    : global::Sungero.Domain.SearchPropertyFilteringServerHandler
    where T : class, global::Sungero.CoreEntities.IRecipient
  {

    public virtual global::System.Linq.IQueryable<T> RecipientsRecipientSearchDialogFiltering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.PropertySearchDialogFilteringEventArgs e)
    {
      return query;
    }

    public VisibilityRuleRecipientsRecipientSearchPropertyFilteringServerHandler()
      : base()
    {
    }
  }



}

// ==================================================================
// VisibilityRuleRecipientsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Server
{
}
