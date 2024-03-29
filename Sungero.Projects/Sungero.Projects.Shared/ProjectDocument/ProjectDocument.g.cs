
// ==================================================================
// ProjectDocumentState.g.cs
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
  public class ProjectDocumentState : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseState, global::Sungero.Projects.IProjectDocumentState
  {
    public ProjectDocumentState(global::Sungero.Projects.IProjectDocument entity) : base(entity) { }

    public new global::Sungero.Projects.IProjectDocumentPropertyStates Properties
    {
      get { return (global::Sungero.Projects.IProjectDocumentPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Projects.Shared.ProjectDocumentPropertyStates(entity);
    }


    public new global::Sungero.Projects.IProjectDocumentControlStates Controls
    {
      get { return (global::Sungero.Projects.IProjectDocumentControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Projects.Shared.ProjectDocumentControlStates(entity);
    }

    public new global::Sungero.Projects.IProjectDocumentPageStates Pages
    {
      get { return (global::Sungero.Projects.IProjectDocumentPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Projects.Shared.ProjectDocumentPageStates(entity);
    }

  }


  public class ProjectDocumentControlStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseControlStates, global::Sungero.Projects.IProjectDocumentControlStates
  {

    protected internal ProjectDocumentControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ProjectDocumentPageStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBasePageStates, global::Sungero.Projects.IProjectDocumentPageStates
  {

    protected internal ProjectDocumentPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ProjectDocumentPropertyStates : 
    global::Sungero.Docflow.Shared.InternalDocumentBasePropertyStates, global::Sungero.Projects.IProjectDocumentPropertyStates
  {
            public new global::Sungero.Projects.IProjectDocumentVersionsCollectionPropertyState<global::Sungero.Projects.IProjectDocumentVersions> Versions
            {
              get { return (global::Sungero.Projects.IProjectDocumentVersionsCollectionPropertyState<global::Sungero.Projects.IProjectDocumentVersions>)base.Versions; }
            }

            protected override global::Sungero.Content.IElectronicDocumentVersionsCollectionPropertyState<global::Sungero.Content.IElectronicDocumentVersions> CreateVersionsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Projects.Shared.ProjectDocumentVersionsCollectionPropertyState<global::Sungero.Projects.IProjectDocumentVersions>(entity, propertyName);
            }
            public new global::Sungero.Projects.IProjectDocumentTrackingCollectionPropertyState<global::Sungero.Projects.IProjectDocumentTracking> Tracking
            {
              get { return (global::Sungero.Projects.IProjectDocumentTrackingCollectionPropertyState<global::Sungero.Projects.IProjectDocumentTracking>)base.Tracking; }
            }

            protected override global::Sungero.Docflow.IOfficialDocumentTrackingCollectionPropertyState<global::Sungero.Docflow.IOfficialDocumentTracking> CreateTrackingState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.Projects.Shared.ProjectDocumentTrackingCollectionPropertyState<global::Sungero.Projects.IProjectDocumentTracking>(entity, propertyName);
            }


    protected internal ProjectDocumentPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ProjectDocumentInfo.g.cs
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
  public class ProjectDocumentInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBaseInfo, global::Sungero.Projects.IProjectDocumentInfo
  {
    public ProjectDocumentInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Projects.IProjectDocumentPropertiesInfo Properties
    {
      get { return (global::Sungero.Projects.IProjectDocumentPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Projects.Shared.ProjectDocumentPropertiesInfo(entityType);
    }

  }

  public class ProjectDocumentPropertiesInfo : 
    global::Sungero.Docflow.Shared.InternalDocumentBasePropertiesInfo, global::Sungero.Projects.IProjectDocumentPropertiesInfo
  {
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Projects.IProjectDocumentVersionsPropertiesInfo> Versions
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Versions");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Projects.IProjectDocumentVersionsPropertiesInfo>(propertyMetadata);
          }
        }
        public new global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.Projects.IProjectDocumentTrackingPropertiesInfo> Tracking
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Tracking");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.Projects.IProjectDocumentTrackingPropertiesInfo>(propertyMetadata);
          }
        }


    protected internal ProjectDocumentPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// ProjectDocumentHandlers.g.cs
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
  public partial class ProjectDocumentSharedHandlers : global::Sungero.Docflow.InternalDocumentBaseSharedHandlers, IProjectDocumentSharedHandlers
  {
    private global::Sungero.Projects.IProjectDocument _obj
    {
      get { return (global::Sungero.Projects.IProjectDocument)this.Entity; }
    }


    public ProjectDocumentSharedHandlers(global::Sungero.Projects.IProjectDocument entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ProjectDocumentResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Projects.Shared.ProjectDocument
{
  /// <summary>
  /// Represents ProjectDocument resources.
  /// </summary>
  public class ProjectDocumentResources : global::Sungero.Docflow.Shared.InternalDocumentBase.InternalDocumentBaseResources, global::Sungero.Projects.ProjectDocument.IProjectDocumentResources
  {
  }
}

// ==================================================================
// ProjectDocumentSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Projects.Shared
{
  public partial class ProjectDocumentFunctions : global::Sungero.Docflow.Shared.InternalDocumentBaseFunctions
  {
    private global::Sungero.Projects.IProjectDocument _obj
    {
      get { return (global::Sungero.Projects.IProjectDocument)this.Entity; }
    }

    public ProjectDocumentFunctions(global::Sungero.Projects.IProjectDocument entity) : base(entity) { }
  }
}

// ==================================================================
// ProjectDocumentFunctions.g.cs
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
  internal static class ProjectDocument
  {
    /// <redirect project="Sungero.Projects.Shared" type="Sungero.Projects.Shared.ProjectDocumentFunctions" />
    internal static  void FillName(global::Sungero.Projects.IProjectDocument projectDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)projectDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("FillName", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Projects.Shared" type="Sungero.Projects.Shared.ProjectDocumentFunctions" />
    internal static  void RefreshDocumentForm(global::Sungero.Projects.IProjectDocument projectDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)projectDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("RefreshDocumentForm", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Projects.Shared" type="Sungero.Projects.Shared.ProjectDocumentFunctions" />
    internal static  void SetRequiredProperties(global::Sungero.Projects.IProjectDocument projectDocument)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)projectDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetRequiredProperties", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Projects.Shared" type="Sungero.Projects.Shared.ProjectDocumentFunctions" />
    internal static  global::System.Boolean NeedClearProject(global::Sungero.Projects.IProjectDocument projectDocument, Sungero.Docflow.Shared.OfficialDocumentDocumentKindChangedEventArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)projectDocument).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("NeedClearProject", new System.Type[] { typeof(Sungero.Docflow.Shared.OfficialDocumentDocumentKindChangedEventArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }

  }
}

// ==================================================================
// ProjectDocumentFilterState.g.cs
// ==================================================================

namespace Sungero.Projects.Shared.ProjectDocument
{

  public class ProjectDocumentFilterInfo : global::Sungero.Docflow.Shared.InternalDocumentBase.InternalDocumentBaseFilterInfo,
    global::Sungero.Projects.IProjectDocumentFilterInfo
  {
  }

  public class ProjectDocumentFilterState : global::Sungero.Docflow.Shared.InternalDocumentBase.InternalDocumentBaseFilterState,
    global::Sungero.Projects.IProjectDocumentFilterState
  {



    public new Sungero.Projects.IProjectDocumentFilterInfo Info
    {
      get
      {
        return (Sungero.Projects.IProjectDocumentFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Projects.Shared.ProjectDocument.ProjectDocumentFilterInfo();
    }

  }
}

// ==================================================================
// ProjectDocumentSharedPublicFunctions.g.cs
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
  public class ProjectDocumentSharedPublicFunctions : global::Sungero.Projects.Shared.IProjectDocumentSharedPublicFunctions
  {
  }
}
