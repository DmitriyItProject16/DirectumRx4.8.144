
// ==================================================================
// ProjectDocumentRightsQueueItemState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared
{
  public class ProjectDocumentRightsQueueItemState : 
    global::Sungero.Projects.Shared.ProjectQueueItemBaseState, global::Sungero.Projects.IProjectDocumentRightsQueueItemState
  {
    public ProjectDocumentRightsQueueItemState(global::Sungero.Projects.IProjectDocumentRightsQueueItem entity) : base(entity) { }

    public new global::Sungero.Projects.IProjectDocumentRightsQueueItemPropertyStates Properties
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItemPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Projects.Shared.ProjectDocumentRightsQueueItemPropertyStates(entity);
    }


    public new global::Sungero.Projects.IProjectDocumentRightsQueueItemControlStates Controls
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItemControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Projects.Shared.ProjectDocumentRightsQueueItemControlStates(entity);
    }

    public new global::Sungero.Projects.IProjectDocumentRightsQueueItemPageStates Pages
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItemPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Projects.Shared.ProjectDocumentRightsQueueItemPageStates(entity);
    }

  }


  public class ProjectDocumentRightsQueueItemControlStates : 
    global::Sungero.Projects.Shared.ProjectQueueItemBaseControlStates, global::Sungero.Projects.IProjectDocumentRightsQueueItemControlStates
  {

    protected internal ProjectDocumentRightsQueueItemControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ProjectDocumentRightsQueueItemPageStates : 
    global::Sungero.Projects.Shared.ProjectQueueItemBasePageStates, global::Sungero.Projects.IProjectDocumentRightsQueueItemPageStates
  {

    protected internal ProjectDocumentRightsQueueItemPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ProjectDocumentRightsQueueItemPropertyStates : 
    global::Sungero.Projects.Shared.ProjectQueueItemBasePropertyStates, global::Sungero.Projects.IProjectDocumentRightsQueueItemPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int64?> DocumentId 
            {
              get { return this.GetPropertyState<global::System.Int64?>("DocumentId"); }
            }


    protected internal ProjectDocumentRightsQueueItemPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ProjectDocumentRightsQueueItemInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared
{
  public class ProjectDocumentRightsQueueItemInfo : 
    global::Sungero.Projects.Shared.ProjectQueueItemBaseInfo, global::Sungero.Projects.IProjectDocumentRightsQueueItemInfo
  {
    public ProjectDocumentRightsQueueItemInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Projects.IProjectDocumentRightsQueueItemPropertiesInfo Properties
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItemPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Projects.Shared.ProjectDocumentRightsQueueItemPropertiesInfo(entityType);
    }

  }

  public class ProjectDocumentRightsQueueItemPropertiesInfo : 
    global::Sungero.Projects.Shared.ProjectQueueItemBasePropertiesInfo, global::Sungero.Projects.IProjectDocumentRightsQueueItemPropertiesInfo
  {
        public global::Sungero.Domain.Shared.ILongIntegerPropertyInfo DocumentId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.LongIntegerPropertyMetadata>("DocumentId");
             return new global::Sungero.Domain.Shared.LongIntegerPropertyInfo(propertyMetadata);
          }
        }


    protected internal ProjectDocumentRightsQueueItemPropertiesInfo(global::System.Type entityType) : base(entityType) { }
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
  public partial class ProjectDocumentRightsQueueItemSharedHandlers : global::Sungero.Projects.ProjectQueueItemBaseSharedHandlers, IProjectDocumentRightsQueueItemSharedHandlers
  {
    private global::Sungero.Projects.IProjectDocumentRightsQueueItem _obj
    {
      get { return (global::Sungero.Projects.IProjectDocumentRightsQueueItem)this.Entity; }
    }
    public virtual void DocumentIdChanged(global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs e) { }




    public ProjectDocumentRightsQueueItemSharedHandlers(global::Sungero.Projects.IProjectDocumentRightsQueueItem entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectDocumentRightsQueueItemResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared.ProjectDocumentRightsQueueItem
{
  /// <summary>
  /// Represents ProjectDocumentRightsQueueItem resources.
  /// </summary>
  public class ProjectDocumentRightsQueueItemResources : global::Sungero.Projects.Shared.ProjectQueueItemBase.ProjectQueueItemBaseResources, global::Sungero.Projects.ProjectDocumentRightsQueueItem.IProjectDocumentRightsQueueItemResources
  {
  }
}

// ==================================================================
// ProjectDocumentRightsQueueItemSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Shared
{
  public partial class ProjectDocumentRightsQueueItemFunctions : global::Sungero.Projects.Shared.ProjectQueueItemBaseFunctions
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
// ProjectDocumentRightsQueueItemFilterState.g.cs
// ==================================================================

namespace Sungero.Projects.Shared.ProjectDocumentRightsQueueItem
{

  public class ProjectDocumentRightsQueueItemFilterInfo : global::Sungero.Projects.Shared.ProjectQueueItemBase.ProjectQueueItemBaseFilterInfo,
    global::Sungero.Projects.IProjectDocumentRightsQueueItemFilterInfo
  {
  }

  public class ProjectDocumentRightsQueueItemFilterState : global::Sungero.Projects.Shared.ProjectQueueItemBase.ProjectQueueItemBaseFilterState,
    global::Sungero.Projects.IProjectDocumentRightsQueueItemFilterState
  {



    public new Sungero.Projects.IProjectDocumentRightsQueueItemFilterInfo Info
    {
      get
      {
        return (Sungero.Projects.IProjectDocumentRightsQueueItemFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Projects.Shared.ProjectDocumentRightsQueueItem.ProjectDocumentRightsQueueItemFilterInfo();
    }

  }
}

// ==================================================================
// ProjectDocumentRightsQueueItemSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared
{
  public class ProjectDocumentRightsQueueItemSharedPublicFunctions : global::Sungero.Projects.Shared.IProjectDocumentRightsQueueItemSharedPublicFunctions
  {
  }
}
