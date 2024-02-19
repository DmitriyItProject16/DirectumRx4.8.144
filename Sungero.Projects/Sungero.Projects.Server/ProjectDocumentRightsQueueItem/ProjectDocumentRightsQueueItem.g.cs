
// ==================================================================
// ProjectDocumentRightsQueueItem.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
    public class ProjectDocumentRightsQueueItemFilter<T> :
      global::Sungero.Projects.Server.ProjectQueueItemBaseFilter<T>
      where T : class, global::Sungero.Projects.IProjectDocumentRightsQueueItem
    {
      private global::Sungero.Projects.IProjectDocumentRightsQueueItemFilterState filter
      {
        get
        {
          return (Sungero.Projects.IProjectDocumentRightsQueueItemFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public ProjectDocumentRightsQueueItemFilter(global::Sungero.Projects.IProjectDocumentRightsQueueItemFilterState filter)
      : base(filter)
      {
      }

      protected ProjectDocumentRightsQueueItemFilter()
      {
      }
    }
      public class ProjectDocumentRightsQueueItemUiFilter<T> :
        global::Sungero.Projects.Server.ProjectQueueItemBaseUiFilter<T>
        where T : class, global::Sungero.Projects.IProjectDocumentRightsQueueItem
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ProjectDocumentRightsQueueItemSearchDialogModel : global::Sungero.Projects.Server.ProjectQueueItemBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String ExternalId { get; protected set; }
                  public override global::System.Int32? Retries { get; protected set; }
                  public override global::System.String Note { get; protected set; }
                  public override global::System.Int64? ProjectId { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBoxBase> Box { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ProcessingStatus { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> LastUpdate { get; protected set; }
                  public override global::System.Collections.Generic.IEnumerable<Sungero.ExchangeCore.IBusinessUnitBox> RootBox { get; protected set; }


                  public virtual global::System.Int64? DocumentId { get; protected set; }



        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Projects.Server.ProjectDocumentRightsQueueItemFilter<global::Sungero.Projects.IProjectDocumentRightsQueueItem>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Projects.Server.ProjectDocumentRightsQueueItemUiFilter<global::Sungero.Projects.IProjectDocumentRightsQueueItem>))]

  public class ProjectDocumentRightsQueueItem :
    global::Sungero.Projects.Server.ProjectQueueItemBase, global::Sungero.Projects.IProjectDocumentRightsQueueItem
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("aa042ddf-a9fb-4dea-883c-d0024b9574da");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Projects.Server.ProjectDocumentRightsQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Projects.IProjectDocumentRightsQueueItem, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Projects.IProjectDocumentRightsQueueItemState State
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItemState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Projects.Shared.ProjectDocumentRightsQueueItemState(this);
    }

    public new virtual global::Sungero.Projects.IProjectDocumentRightsQueueItemInfo Info
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItemInfo)base.Info; }
    }

    public new virtual global::Sungero.Projects.IProjectDocumentRightsQueueItemAccessRights AccessRights
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItemAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Projects.Server.ProjectDocumentRightsQueueItemAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Projects.Server.ProjectDocumentRightsQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Projects.Shared.ProjectDocumentRightsQueueItemFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Projects.ProjectDocumentRightsQueueItemServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Projects.ProjectDocumentRightsQueueItemSharedHandlers(this);
    }

    private global::System.Int64? _DocumentId;
    public virtual global::System.Int64? DocumentId
    {
      get
      {
        return this._DocumentId;
      }

      set
      {
        this.SetPropertyValue("DocumentId", this._DocumentId, value, (propertyValue) => { this._DocumentId = propertyValue; }, this.DocumentIdChangedHandler);
      }
    }










    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Projects.ProjectDocumentRightsQueueItemCreatingFromServerHandler", new object[] { (global::Sungero.Projects.IProjectDocumentRightsQueueItem)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Projects.ProjectDocumentRightsQueueItemCreatingFromServerHandler((global::Sungero.Projects.IProjectDocumentRightsQueueItem)entitySource, this.Info);
    }

    #region Framework events

    protected void DocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.DocumentId, this.DocumentId, this);
     ((global::Sungero.Projects.IProjectDocumentRightsQueueItemSharedHandlers)this.SharedHandlers).DocumentIdChanged(args);
    }



    #endregion


    public ProjectDocumentRightsQueueItem()
    {
    }

  }
}

// ==================================================================
// ProjectDocumentRightsQueueItemHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects
{

  public partial class ProjectDocumentRightsQueueItemFilteringServerHandler<T>
    : global::Sungero.Projects.ProjectQueueItemBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Projects.IProjectDocumentRightsQueueItem
  {
    private global::Sungero.Projects.IProjectDocumentRightsQueueItemFilterState _filter
    {
      get
      {
        return (Sungero.Projects.IProjectDocumentRightsQueueItemFilterState)this.Filter;
      }
    }

    public ProjectDocumentRightsQueueItemFilteringServerHandler(global::Sungero.Projects.IProjectDocumentRightsQueueItemFilterState filter)
    : base(filter)
    {
    }

    protected ProjectDocumentRightsQueueItemFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class ProjectDocumentRightsQueueItemUiFilteringServerHandler<T>
    : global::Sungero.Projects.ProjectQueueItemBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Projects.IProjectDocumentRightsQueueItem
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ProjectDocumentRightsQueueItemSearchDialogServerHandler : global::Sungero.Projects.ProjectQueueItemBaseSearchDialogServerHandler
   {
     private global::Sungero.Projects.Server.ProjectDocumentRightsQueueItemSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Projects.Server.ProjectDocumentRightsQueueItemSearchDialogModel)this.Dialog;
       }
     }

     public ProjectDocumentRightsQueueItemSearchDialogServerHandler(global::Sungero.Projects.Server.ProjectDocumentRightsQueueItemSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ProjectDocumentRightsQueueItemServerHandlers : global::Sungero.Projects.ProjectQueueItemBaseServerHandlers
  {
    private global::Sungero.Projects.IProjectDocumentRightsQueueItem _obj
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItem)this.Entity; }
    }

    public ProjectDocumentRightsQueueItemServerHandlers(global::Sungero.Projects.IProjectDocumentRightsQueueItem entity)
      : base(entity)
    {
    }
  }

  public partial class ProjectDocumentRightsQueueItemCreatingFromServerHandler : global::Sungero.Projects.ProjectQueueItemBaseCreatingFromServerHandler
  {
    private global::Sungero.Projects.IProjectDocumentRightsQueueItem _source
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItem)this.Source; }
    }

    private global::Sungero.Projects.IProjectDocumentRightsQueueItemInfo _info
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItemInfo)this._Info; }
    }

    public ProjectDocumentRightsQueueItemCreatingFromServerHandler(global::Sungero.Projects.IProjectDocumentRightsQueueItem source, global::Sungero.Projects.IProjectDocumentRightsQueueItemInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ProjectDocumentRightsQueueItemEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
}

// ==================================================================
// ProjectDocumentRightsQueueItemAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
  public class ProjectDocumentRightsQueueItemAccessRights : 
    Sungero.Projects.Server.ProjectQueueItemBaseAccessRights, Sungero.Projects.IProjectDocumentRightsQueueItemAccessRights
  {

    public ProjectDocumentRightsQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ProjectDocumentRightsQueueItemTypeAccessRights : 
    Sungero.Projects.Server.ProjectQueueItemBaseTypeAccessRights, Sungero.Projects.IProjectDocumentRightsQueueItemAccessRights
  {

    public ProjectDocumentRightsQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ProjectDocumentRightsQueueItemRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
    public class ProjectDocumentRightsQueueItemRepositoryImplementer<T> : 
      global::Sungero.Projects.Server.ProjectQueueItemBaseRepositoryImplementer<T>,
      global::Sungero.Projects.IProjectDocumentRightsQueueItemRepositoryImplementer<T>
      where T : global::Sungero.Projects.IProjectDocumentRightsQueueItem 
    {
       public new global::Sungero.Projects.IProjectDocumentRightsQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Projects.IProjectDocumentRightsQueueItemInfo Info
       {
          get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Projects.Server.ProjectDocumentRightsQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ProjectDocumentRightsQueueItemPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
}

// ==================================================================
// ProjectDocumentRightsQueueItemServerFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Server
{
  public partial class ProjectDocumentRightsQueueItemFunctions : global::Sungero.Projects.Server.ProjectQueueItemBaseFunctions
  {
    private global::Sungero.Projects.IProjectDocumentRightsQueueItem _obj
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItem)this.Entity; }
    }

    public ProjectDocumentRightsQueueItemFunctions(global::Sungero.Projects.IProjectDocumentRightsQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectDocumentRightsQueueItemFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Functions
{
  internal static class ProjectDocumentRightsQueueItem
  {
  }
}

// ==================================================================
// ProjectDocumentRightsQueueItemServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Server
{
  public class ProjectDocumentRightsQueueItemServerPublicFunctions : global::Sungero.Projects.Server.IProjectDocumentRightsQueueItemServerPublicFunctions
  {
  }
}

// ==================================================================
// ProjectDocumentRightsQueueItemQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Queries
{
  public class ProjectDocumentRightsQueueItem
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Projects.Server.ProjectDocumentRightsQueueItem.ProjectDocumentRightsQueueItemQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
