
// ==================================================================
// PowerOfAttorneyServiceApp.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Server
{
    public class PowerOfAttorneyServiceAppFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp
    {
      protected new global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppFilterState Filter { get; private set; }

      private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppFilterState filter
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

      public PowerOfAttorneyServiceAppFilter(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected PowerOfAttorneyServiceAppFilter()
      {
      }
    }
      public class PowerOfAttorneyServiceAppUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class PowerOfAttorneyServiceAppSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.String Uri { get; protected set; }
                  public virtual global::System.String Note { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> Status { get; protected set; }


        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.PowerOfAttorneyCore.Server.PowerOfAttorneyServiceAppFilter<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.PowerOfAttorneyCore.Server.PowerOfAttorneyServiceAppUiFilter<global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp>))]

  public class PowerOfAttorneyServiceApp :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("6858d083-8a73-4e42-8997-3319584c1d4f");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.PowerOfAttorneyCore.Server.PowerOfAttorneyServiceApp.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppState State
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceAppState(this);
    }

    public new virtual global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppInfo Info
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppInfo)base.Info; }
    }

    public new virtual global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppAccessRights AccessRights
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.PowerOfAttorneyCore.Server.PowerOfAttorneyServiceAppAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.PowerOfAttorneyCore.Server.PowerOfAttorneyServiceAppFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.PowerOfAttorneyCore.Shared.PowerOfAttorneyServiceAppFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.PowerOfAttorneyCore.PowerOfAttorneyServiceAppServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.PowerOfAttorneyCore.PowerOfAttorneyServiceAppSharedHandlers(this);
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
    private global::System.String _Uri;
    public virtual global::System.String Uri
    {
      get
      {
        return this._Uri;
      }

      set
      {
        this.SetPropertyValue("Uri", this._Uri, value, (propertyValue) => { this._Uri = propertyValue; }, this.UriChangedHandler);
      }
    }
    private global::System.String _APIKey;
    public virtual global::System.String APIKey
    {
      get
      {
        return this._APIKey;
      }

      set
      {
        this.SetPropertyValue("APIKey", this._APIKey, value, (propertyValue) => { this._APIKey = propertyValue; }, this.APIKeyChangedHandler);
      }
    }



    private global::System.String _Note;
    [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
    public virtual global::System.String Note
    {
      get
      {
        return this._Note;
      }

      set
      {
        this.SetPropertyValue("Note", this._Note, value, (propertyValue) => { this._Note = propertyValue; }, this.NoteChangedHandler);
      }
    }








    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.PowerOfAttorneyCore.PowerOfAttorneyServiceAppCreatingFromServerHandler", new object[] { (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.PowerOfAttorneyCore.PowerOfAttorneyServiceAppCreatingFromServerHandler((global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void UriChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Uri, this.Uri, this);
     ((global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppSharedHandlers)this.SharedHandlers).UriChanged(args);
    }

    protected void APIKeyChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.APIKey, this.APIKey, this);
     ((global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppSharedHandlers)this.SharedHandlers).APIKeyChanged(args);
    }

    protected void NoteChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.TextPropertyChangedEventArgs(this.State.Properties.Note, this.Note, this);
     ((global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppSharedHandlers)this.SharedHandlers).NoteChanged(args);
    }



    #endregion


    public PowerOfAttorneyServiceApp()
    {
    }

  }
}

// ==================================================================
// PowerOfAttorneyServiceAppHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore
{

  public partial class PowerOfAttorneyServiceAppFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppFilterState Filter { get; private set; }

    private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public PowerOfAttorneyServiceAppFilteringServerHandler(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected PowerOfAttorneyServiceAppFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class PowerOfAttorneyServiceAppUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class PowerOfAttorneyServiceAppSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.PowerOfAttorneyCore.Server.PowerOfAttorneyServiceAppSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.PowerOfAttorneyCore.Server.PowerOfAttorneyServiceAppSearchDialogModel)this.Dialog;
       }
     }

     public PowerOfAttorneyServiceAppSearchDialogServerHandler(global::Sungero.PowerOfAttorneyCore.Server.PowerOfAttorneyServiceAppSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class PowerOfAttorneyServiceAppServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp _obj
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp)this.Entity; }
    }

    public PowerOfAttorneyServiceAppServerHandlers(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp entity)
      : base(entity)
    {
    }
  }

  public partial class PowerOfAttorneyServiceAppCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp _source
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp)this.Source; }
    }

    private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppInfo _info
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppInfo)this._Info; }
    }

    public PowerOfAttorneyServiceAppCreatingFromServerHandler(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp source, global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// PowerOfAttorneyServiceAppEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Server
{
}

// ==================================================================
// PowerOfAttorneyServiceAppAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Server
{
  public class PowerOfAttorneyServiceAppAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppAccessRights
  {

    public PowerOfAttorneyServiceAppAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class PowerOfAttorneyServiceAppTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppAccessRights
  {

    public PowerOfAttorneyServiceAppTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// PowerOfAttorneyServiceAppRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Server
{
    public class PowerOfAttorneyServiceAppRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppRepositoryImplementer<T>
      where T : global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp 
    {
       public new global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppAccessRights AccessRights
       {
          get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppAccessRights)base.AccessRights; }
       }

       public new global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppInfo Info
       {
          get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceAppInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.PowerOfAttorneyCore.Server.PowerOfAttorneyServiceAppTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// PowerOfAttorneyServiceAppPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Server
{
}

// ==================================================================
// PowerOfAttorneyServiceAppServerFunctions.g.cs
// ==================================================================

namespace Sungero.PowerOfAttorneyCore.Server
{
  public partial class PowerOfAttorneyServiceAppFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp _obj
    {
      get { return (global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp)this.Entity; }
    }

    public PowerOfAttorneyServiceAppFunctions(global::Sungero.PowerOfAttorneyCore.IPowerOfAttorneyServiceApp entity) : base(entity) { }
  }
}

// ==================================================================
// PowerOfAttorneyServiceAppFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Functions
{
  internal static class PowerOfAttorneyServiceApp
  {
  }
}

// ==================================================================
// PowerOfAttorneyServiceAppServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Server
{
  public class PowerOfAttorneyServiceAppServerPublicFunctions : global::Sungero.PowerOfAttorneyCore.Server.IPowerOfAttorneyServiceAppServerPublicFunctions
  {
  }
}

// ==================================================================
// PowerOfAttorneyServiceAppQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.PowerOfAttorneyCore.Queries
{
  public class PowerOfAttorneyServiceApp
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.PowerOfAttorneyCore.Server.PowerOfAttorneyServiceApp.PowerOfAttorneyServiceAppQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
