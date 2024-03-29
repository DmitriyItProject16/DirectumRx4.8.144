
// ==================================================================
// ExternalEntityLink.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
    public class ExternalEntityLinkFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.Commons.IExternalEntityLink
    {
      protected new global::Sungero.Commons.IExternalEntityLinkFilterState Filter { get; private set; }

      private global::Sungero.Commons.IExternalEntityLinkFilterState filter
      {
        get
        {
          return this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ExternalEntityLinkFilter(global::Sungero.Commons.IExternalEntityLinkFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ExternalEntityLinkFilter()
      {
      }
    }
      public class ExternalEntityLinkUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.Commons.IExternalEntityLink
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ExternalEntityLinkSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }



                  public virtual global::System.String EntityType { get; protected set; }
                  public virtual global::System.Int64? EntityId { get; protected set; }
                  public virtual global::System.String ExtEntityType { get; protected set; }
                  public virtual global::System.String ExtEntityId { get; protected set; }
                  public virtual global::System.String ExtSystemId { get; protected set; }
                  public virtual global::System.Boolean? IsDeleted { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> SyncDate { get; protected set; }


        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Commons.Server.ExternalEntityLinkFilter<global::Sungero.Commons.IExternalEntityLink>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Commons.Server.ExternalEntityLinkUiFilter<global::Sungero.Commons.IExternalEntityLink>))]

  public class ExternalEntityLink :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.Commons.IExternalEntityLink
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("4346363e-39b9-40eb-9c12-64f0cf48d87f");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Commons.Server.ExternalEntityLink.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Commons.IExternalEntityLink, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Commons.IExternalEntityLinkState State
    {
      get { return (global::Sungero.Commons.IExternalEntityLinkState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Commons.Shared.ExternalEntityLinkState(this);
    }

    public new virtual global::Sungero.Commons.IExternalEntityLinkInfo Info
    {
      get { return (global::Sungero.Commons.IExternalEntityLinkInfo)base.Info; }
    }

    public new virtual global::Sungero.Commons.IExternalEntityLinkAccessRights AccessRights
    {
      get { return (global::Sungero.Commons.IExternalEntityLinkAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Commons.Server.ExternalEntityLinkAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Commons.Server.ExternalEntityLinkFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Commons.Shared.ExternalEntityLinkFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Commons.ExternalEntityLinkServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Commons.ExternalEntityLinkSharedHandlers(this);
    }

    private global::System.String _EntityType;
    public virtual global::System.String EntityType
    {
      get
      {
        return this._EntityType;
      }

      set
      {
        this.SetPropertyValue("EntityType", this._EntityType, value, (propertyValue) => { this._EntityType = propertyValue; }, this.EntityTypeChangedHandler);
      }
    }
    private global::System.Int64? _EntityId;
    public virtual global::System.Int64? EntityId
    {
      get
      {
        return this._EntityId;
      }

      set
      {
        this.SetPropertyValue("EntityId", this._EntityId, value, (propertyValue) => { this._EntityId = propertyValue; }, this.EntityIdChangedHandler);
      }
    }
    private global::System.String _ExtEntityType;
    public virtual global::System.String ExtEntityType
    {
      get
      {
        return this._ExtEntityType;
      }

      set
      {
        this.SetPropertyValue("ExtEntityType", this._ExtEntityType, value, (propertyValue) => { this._ExtEntityType = propertyValue; }, this.ExtEntityTypeChangedHandler);
      }
    }
    private global::System.String _ExtEntityId;
    public virtual global::System.String ExtEntityId
    {
      get
      {
        return this._ExtEntityId;
      }

      set
      {
        this.SetPropertyValue("ExtEntityId", this._ExtEntityId, value, (propertyValue) => { this._ExtEntityId = propertyValue; }, this.ExtEntityIdChangedHandler);
      }
    }
    private global::System.String _ExtSystemId;
    public virtual global::System.String ExtSystemId
    {
      get
      {
        return this._ExtSystemId;
      }

      set
      {
        this.SetPropertyValue("ExtSystemId", this._ExtSystemId, value, (propertyValue) => { this._ExtSystemId = propertyValue; }, this.ExtSystemIdChangedHandler);
      }
    }
    private global::System.DateTime? _SyncDate;
    public virtual global::System.DateTime? SyncDate
    {
      get
      {
        return this._SyncDate;
      }

      set
      {
        this.SetPropertyValue("SyncDate", this._SyncDate, value, (propertyValue) => { this._SyncDate = propertyValue; }, this.SyncDateChangedHandler);
      }
    }
    private global::System.Boolean? _IsDeleted;
    public virtual global::System.Boolean? IsDeleted
    {
      get
      {
        return this._IsDeleted;
      }

      set
      {
        this.SetPropertyValue("IsDeleted", this._IsDeleted, value, (propertyValue) => { this._IsDeleted = propertyValue; }, this.IsDeletedChangedHandler);
      }
    }
    private global::System.String _Name;
    public virtual global::System.String Name
    {
      get
      {
        return this._Name;
      }

      set
      {
        this.SetPropertyValue("Name", this._Name, value, (propertyValue) => { this._Name = propertyValue; }, this.NameChangedHandler);
      }
    }










    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Commons.ExternalEntityLinkCreatingFromServerHandler", new object[] { (global::Sungero.Commons.IExternalEntityLink)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Commons.ExternalEntityLinkCreatingFromServerHandler((global::Sungero.Commons.IExternalEntityLink)entitySource, this.Info);
    }

    #region Framework events

    protected void EntityTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.EntityType, this.EntityType, this);
     ((global::Sungero.Commons.IExternalEntityLinkSharedHandlers)this.SharedHandlers).EntityTypeChanged(args);
    }

    protected void EntityIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.EntityId, this.EntityId, this);
     ((global::Sungero.Commons.IExternalEntityLinkSharedHandlers)this.SharedHandlers).EntityIdChanged(args);
    }

    protected void ExtEntityTypeChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ExtEntityType, this.ExtEntityType, this);
     ((global::Sungero.Commons.IExternalEntityLinkSharedHandlers)this.SharedHandlers).ExtEntityTypeChanged(args);
    }

    protected void ExtEntityIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ExtEntityId, this.ExtEntityId, this);
     ((global::Sungero.Commons.IExternalEntityLinkSharedHandlers)this.SharedHandlers).ExtEntityIdChanged(args);
    }

    protected void ExtSystemIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.ExtSystemId, this.ExtSystemId, this);
     ((global::Sungero.Commons.IExternalEntityLinkSharedHandlers)this.SharedHandlers).ExtSystemIdChanged(args);
    }

    protected void SyncDateChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.SyncDate, this.SyncDate, this);
     ((global::Sungero.Commons.IExternalEntityLinkSharedHandlers)this.SharedHandlers).SyncDateChanged(args);
    }

    protected void IsDeletedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs(this.State.Properties.IsDeleted, this.IsDeleted, this);
     ((global::Sungero.Commons.IExternalEntityLinkSharedHandlers)this.SharedHandlers).IsDeletedChanged(args);
    }

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.Commons.IExternalEntityLinkSharedHandlers)this.SharedHandlers).NameChanged(args);
    }



    #endregion


    public ExternalEntityLink()
    {
    }

  }
}

// ==================================================================
// ExternalEntityLinkHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons
{

  public partial class ExternalEntityLinkFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.Commons.IExternalEntityLink
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.Commons.IExternalEntityLinkFilterState Filter { get; private set; }

    private global::Sungero.Commons.IExternalEntityLinkFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ExternalEntityLinkFilteringServerHandler(global::Sungero.Commons.IExternalEntityLinkFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ExternalEntityLinkFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ExternalEntityLinkUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.Commons.IExternalEntityLink
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ExternalEntityLinkSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.Commons.Server.ExternalEntityLinkSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Commons.Server.ExternalEntityLinkSearchDialogModel)this.Dialog;
       }
     }

     public ExternalEntityLinkSearchDialogServerHandler(global::Sungero.Commons.Server.ExternalEntityLinkSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ExternalEntityLinkServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.Commons.IExternalEntityLink _obj
    {
      get { return (global::Sungero.Commons.IExternalEntityLink)this.Entity; }
    }

    public ExternalEntityLinkServerHandlers(global::Sungero.Commons.IExternalEntityLink entity)
      : base(entity)
    {
    }
  }

  public partial class ExternalEntityLinkCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.Commons.IExternalEntityLink _source
    {
      get { return (global::Sungero.Commons.IExternalEntityLink)this.Source; }
    }

    private global::Sungero.Commons.IExternalEntityLinkInfo _info
    {
      get { return (global::Sungero.Commons.IExternalEntityLinkInfo)this._Info; }
    }

    public ExternalEntityLinkCreatingFromServerHandler(global::Sungero.Commons.IExternalEntityLink source, global::Sungero.Commons.IExternalEntityLinkInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ExternalEntityLinkEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
}

// ==================================================================
// ExternalEntityLinkAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
  public class ExternalEntityLinkAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.Commons.IExternalEntityLinkAccessRights
  {

    public ExternalEntityLinkAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ExternalEntityLinkTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.Commons.IExternalEntityLinkAccessRights
  {

    public ExternalEntityLinkTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ExternalEntityLinkRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
    public class ExternalEntityLinkRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.Commons.IExternalEntityLinkRepositoryImplementer<T>
      where T : global::Sungero.Commons.IExternalEntityLink 
    {
       public new global::Sungero.Commons.IExternalEntityLinkAccessRights AccessRights
       {
          get { return (global::Sungero.Commons.IExternalEntityLinkAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Commons.IExternalEntityLinkInfo Info
       {
          get { return (global::Sungero.Commons.IExternalEntityLinkInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Commons.Server.ExternalEntityLinkTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ExternalEntityLinkPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
}

// ==================================================================
// ExternalEntityLinkServerFunctions.g.cs
// ==================================================================

namespace Sungero.Commons.Server
{
  public partial class ExternalEntityLinkFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.Commons.IExternalEntityLink _obj
    {
      get { return (global::Sungero.Commons.IExternalEntityLink)this.Entity; }
    }

    public ExternalEntityLinkFunctions(global::Sungero.Commons.IExternalEntityLink entity) : base(entity) { }
  }
}

// ==================================================================
// ExternalEntityLinkFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Functions
{
  internal static class ExternalEntityLink
  {
    /// <redirect project="Sungero.Commons.Server" type="Sungero.Commons.Server.ExternalEntityLinkFunctions" />
    [global::Sungero.Core.RemoteAttribute(IsPure = true)]
    internal static  global::Sungero.Domain.Shared.IEntity GetEntity(global::Sungero.Commons.IExternalEntityLink externalEntityLink)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)externalEntityLink).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetEntity", new System.Type[] {  });
      return (global::Sungero.Domain.Shared.IEntity)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// ExternalEntityLinkServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Server
{
  public class ExternalEntityLinkServerPublicFunctions : global::Sungero.Commons.Server.IExternalEntityLinkServerPublicFunctions
  {
  }
}

// ==================================================================
// ExternalEntityLinkQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Commons.Queries
{
  public class ExternalEntityLink
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Commons.Server.ExternalEntityLink.ExternalEntityLinkQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
