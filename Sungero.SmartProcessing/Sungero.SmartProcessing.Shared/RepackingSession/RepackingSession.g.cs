
// ==================================================================
// RepackingSessionState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class RepackingSessionState : 
    global::Sungero.CoreEntities.Shared.DatabookEntryState, global::Sungero.SmartProcessing.IRepackingSessionState
  {
    public RepackingSessionState(global::Sungero.SmartProcessing.IRepackingSession entity) : base(entity) { }

    public new global::Sungero.SmartProcessing.IRepackingSessionPropertyStates Properties
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.SmartProcessing.Shared.RepackingSessionPropertyStates(entity);
    }


    public new global::Sungero.SmartProcessing.IRepackingSessionControlStates Controls
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.SmartProcessing.Shared.RepackingSessionControlStates(entity);
    }

    public new global::Sungero.SmartProcessing.IRepackingSessionPageStates Pages
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionPageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.SmartProcessing.Shared.RepackingSessionPageStates(entity);
    }

  }


  public class RepackingSessionControlStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryControlStates, global::Sungero.SmartProcessing.IRepackingSessionControlStates
  {

    protected internal RepackingSessionControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class RepackingSessionPageStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPageStates, global::Sungero.SmartProcessing.IRepackingSessionPageStates
  {
        public global::Sungero.Domain.Shared.IStandalonePageState MainPage
        {
        get { return this.GetPageState<Sungero.Domain.Shared.IStandalonePageState>("Card"); }
        }


    protected internal RepackingSessionPageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class RepackingSessionPropertyStates : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertyStates, global::Sungero.SmartProcessing.IRepackingSessionPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> SessionId 
            {
              get { return this.GetPropertyState<global::System.String>("SessionId"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int64?> AssignmentId 
            {
              get { return this.GetPropertyState<global::System.Int64?>("AssignmentId"); }
            }
            public global::Sungero.SmartProcessing.IRepackingSessionOriginalDocumentsCollectionPropertyState<global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments> OriginalDocuments 
            {
              get { return this.GetPropertyState("OriginalDocuments", this.CreateOriginalDocumentsState); }
            }

            protected virtual global::Sungero.SmartProcessing.IRepackingSessionOriginalDocumentsCollectionPropertyState<global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments> CreateOriginalDocumentsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.SmartProcessing.Shared.RepackingSessionOriginalDocumentsCollectionPropertyState<global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments>(entity, propertyName);
            }
            public global::Sungero.SmartProcessing.IRepackingSessionNewDocumentsCollectionPropertyState<global::Sungero.SmartProcessing.IRepackingSessionNewDocuments> NewDocuments 
            {
              get { return this.GetPropertyState("NewDocuments", this.CreateNewDocumentsState); }
            }

            protected virtual global::Sungero.SmartProcessing.IRepackingSessionNewDocumentsCollectionPropertyState<global::Sungero.SmartProcessing.IRepackingSessionNewDocuments> CreateNewDocumentsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.SmartProcessing.Shared.RepackingSessionNewDocumentsCollectionPropertyState<global::Sungero.SmartProcessing.IRepackingSessionNewDocuments>(entity, propertyName);
            }
            public global::Sungero.SmartProcessing.IRepackingSessionErrorsCollectionPropertyState<global::Sungero.SmartProcessing.IRepackingSessionErrors> Errors 
            {
              get { return this.GetPropertyState("Errors", this.CreateErrorsState); }
            }

            protected virtual global::Sungero.SmartProcessing.IRepackingSessionErrorsCollectionPropertyState<global::Sungero.SmartProcessing.IRepackingSessionErrors> CreateErrorsState(global::Sungero.Domain.Shared.IEntity entity, string propertyName)
            {
              return new global::Sungero.SmartProcessing.Shared.RepackingSessionErrorsCollectionPropertyState<global::Sungero.SmartProcessing.IRepackingSessionErrors>(entity, propertyName);
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.DateTime?> CloseDate 
            {
              get { return this.GetPropertyState<global::System.DateTime?>("CloseDate"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Boolean?> ResultsApplied 
            {
              get { return this.GetPropertyState<global::System.Boolean?>("ResultsApplied"); }
            }


    protected internal RepackingSessionPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// RepackingSessionInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class RepackingSessionInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryInfo, global::Sungero.SmartProcessing.IRepackingSessionInfo
  {
    public RepackingSessionInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.SmartProcessing.IRepackingSessionPropertiesInfo Properties
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.SmartProcessing.Shared.RepackingSessionPropertiesInfo(entityType);
    }

  }

  public class RepackingSessionPropertiesInfo : 
    global::Sungero.CoreEntities.Shared.DatabookEntryPropertiesInfo, global::Sungero.SmartProcessing.IRepackingSessionPropertiesInfo
  {
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo SessionId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("SessionId");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ILongIntegerPropertyInfo AssignmentId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.LongIntegerPropertyMetadata>("AssignmentId");
             return new global::Sungero.Domain.Shared.LongIntegerPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.SmartProcessing.IRepackingSessionOriginalDocumentsPropertiesInfo> OriginalDocuments 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("OriginalDocuments");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.SmartProcessing.IRepackingSessionOriginalDocumentsPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.SmartProcessing.IRepackingSessionNewDocumentsPropertiesInfo> NewDocuments 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("NewDocuments");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.SmartProcessing.IRepackingSessionNewDocumentsPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ICollectionPropertyInfo<global::Sungero.SmartProcessing.IRepackingSessionErrorsPropertiesInfo> Errors 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.CollectionPropertyMetadata>("Errors");
             return new global::Sungero.Domain.Shared.CollectionPropertyInfo<global::Sungero.SmartProcessing.IRepackingSessionErrorsPropertiesInfo>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IDateTimePropertyInfo CloseDate 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.DateTimePropertyMetadata>("CloseDate");
             return new global::Sungero.Domain.Shared.DateTimePropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IBooleanPropertyInfo ResultsApplied 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.BooleanPropertyMetadata>("ResultsApplied");
             return new global::Sungero.Domain.Shared.BooleanPropertyInfo(propertyMetadata);
          }
        }


    protected internal RepackingSessionPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// RepackingSessionHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing
{
  public partial class RepackingSessionSharedHandlers : global::Sungero.CoreEntities.DatabookEntrySharedHandlers, IRepackingSessionSharedHandlers
  {
    private global::Sungero.SmartProcessing.IRepackingSession _obj
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSession)this.Entity; }
    }
    public virtual void NameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void SessionIdChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void AssignmentIdChanged(global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs e) { }


    public virtual void OriginalDocumentsChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }


    public virtual void NewDocumentsChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }


    public virtual void ErrorsChanged(global::Sungero.Domain.Shared.CollectionPropertyChangedEventArgs e) { }


    public virtual void CloseDateChanged(global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs e) { }


    public virtual void ResultsAppliedChanged(global::Sungero.Domain.Shared.BooleanPropertyChangedEventArgs e) { }




    public RepackingSessionSharedHandlers(global::Sungero.SmartProcessing.IRepackingSession entity) : base(entity)
    {
    }
  }

  public partial class RepackingSessionOriginalDocumentsSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers, IRepackingSessionOriginalDocumentsSharedHandlers
  {
    private global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments _obj
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments)this.Entity; }
    }
    public virtual void OriginalDocumentsDocumentIdChanged(global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs e) { }


    public virtual void OriginalDocumentsVersionNumberChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }


    public virtual void OriginalDocumentsDocumentNameChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }


    public virtual void OriginalDocumentsResultVersionNumberChanged(global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs e) { }



    public RepackingSessionOriginalDocumentsSharedHandlers(global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments entity) : base(entity)
    {
    }
  }

  public partial class RepackingSessionOriginalDocumentsSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.SmartProcessing.IRepackingSession _obj
    { 
      get { return (global::Sungero.SmartProcessing.IRepackingSession)this.Entity; }
    }

    private global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments _added
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments)this._Added; }
    }

    private global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments _deleted
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments)this._Deleted; }
    }

    private global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments _source
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionOriginalDocuments)this._Source; }
    }

    public virtual void OriginalDocumentsAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void OriginalDocumentsDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public RepackingSessionOriginalDocumentsSharedCollectionHandlers(global::Sungero.SmartProcessing.IRepackingSession entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

  public partial class RepackingSessionNewDocumentsSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers, IRepackingSessionNewDocumentsSharedHandlers
  {
    private global::Sungero.SmartProcessing.IRepackingSessionNewDocuments _obj
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionNewDocuments)this.Entity; }
    }
    public virtual void NewDocumentsDocumentIdChanged(global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs e) { }



    public RepackingSessionNewDocumentsSharedHandlers(global::Sungero.SmartProcessing.IRepackingSessionNewDocuments entity) : base(entity)
    {
    }
  }

  public partial class RepackingSessionNewDocumentsSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.SmartProcessing.IRepackingSession _obj
    { 
      get { return (global::Sungero.SmartProcessing.IRepackingSession)this.Entity; }
    }

    private global::Sungero.SmartProcessing.IRepackingSessionNewDocuments _added
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionNewDocuments)this._Added; }
    }

    private global::Sungero.SmartProcessing.IRepackingSessionNewDocuments _deleted
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionNewDocuments)this._Deleted; }
    }

    private global::Sungero.SmartProcessing.IRepackingSessionNewDocuments _source
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionNewDocuments)this._Source; }
    }

    public virtual void NewDocumentsAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void NewDocumentsDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public RepackingSessionNewDocumentsSharedCollectionHandlers(global::Sungero.SmartProcessing.IRepackingSession entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

  public partial class RepackingSessionErrorsSharedHandlers : global::Sungero.Domain.Shared.ChildEntitySharedHandlers, IRepackingSessionErrorsSharedHandlers
  {
    private global::Sungero.SmartProcessing.IRepackingSessionErrors _obj
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionErrors)this.Entity; }
    }
    public virtual void ErrorsTextChanged(global::Sungero.Domain.Shared.StringPropertyChangedEventArgs e) { }



    public RepackingSessionErrorsSharedHandlers(global::Sungero.SmartProcessing.IRepackingSessionErrors entity) : base(entity)
    {
    }
  }

  public partial class RepackingSessionErrorsSharedCollectionHandlers : global::Sungero.Domain.Shared.ChildEntitySharedCollectionHandlers
  {
    private global::Sungero.SmartProcessing.IRepackingSession _obj
    { 
      get { return (global::Sungero.SmartProcessing.IRepackingSession)this.Entity; }
    }

    private global::Sungero.SmartProcessing.IRepackingSessionErrors _added
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionErrors)this._Added; }
    }

    private global::Sungero.SmartProcessing.IRepackingSessionErrors _deleted
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionErrors)this._Deleted; }
    }

    private global::Sungero.SmartProcessing.IRepackingSessionErrors _source
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionErrors)this._Source; }
    }

    public virtual void ErrorsAdded(global::Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e) { }
    public virtual void ErrorsDeleted(global::Sungero.Domain.Shared.CollectionPropertyDeletedEventArgs e) { }

    public RepackingSessionErrorsSharedCollectionHandlers(global::Sungero.SmartProcessing.IRepackingSession entity, global::Sungero.Domain.Shared.IChildEntity added, global::Sungero.Domain.Shared.IChildEntity deleted, global::Sungero.Domain.Shared.IChildEntity source)
      : base (entity, added, deleted, source)
    {
    }
  }

}

// ==================================================================
// RepackingSessionResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared.RepackingSession
{
  /// <summary>
  /// Represents RepackingSession resources.
  /// </summary>
  public class RepackingSessionResources : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryResources, global::Sungero.SmartProcessing.RepackingSession.IRepackingSessionResources
  {
    public virtual global::CommonLibrary.LocalizedString RepackingNewDocumentSaveError
    {
      get
      {
        return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IRepackingSession) , "RepackingNewDocumentSaveError");
      }
    }

    public virtual global::CommonLibrary.LocalizedString RepackingNewDocumentSaveErrorFormat(params object[] args)
    {
      return global::Sungero.Domain.Shared.ResourceService.Instance.GetEntityStringResource(typeof(Sungero.SmartProcessing.IRepackingSession), "RepackingNewDocumentSaveError", false, args);
    }

  }
}

// ==================================================================
// RepackingSessionSharedFunctions.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Shared
{
  public partial class RepackingSessionFunctions : global::Sungero.CoreEntities.Shared.DatabookEntryFunctions
  {
    private global::Sungero.SmartProcessing.IRepackingSession _obj
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSession)this.Entity; }
    }

    public RepackingSessionFunctions(global::Sungero.SmartProcessing.IRepackingSession entity) : base(entity) { }
  }
}

// ==================================================================
// RepackingSessionFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Functions
{
  internal static class RepackingSession
  {
    internal static class Remote
    {
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.RepackingSessionFunctions" />
      internal static  global::System.String GetUrl(global::Sungero.SmartProcessing.IRepackingSession repackingSession)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.String>(
          global::System.Guid.Parse("3724e760-a28a-42ec-a91a-217df42c3665"),
          "GetUrl(global::Sungero.SmartProcessing.IRepackingSession)"
          , repackingSession);
      }
      /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.RepackingSessionFunctions" />
      internal static  global::Sungero.SmartProcessing.IRepackingSession GetActiveSessionByAssignmentId(global::System.Int64 assignmentId)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::Sungero.SmartProcessing.IRepackingSession>(
          global::System.Guid.Parse("3724e760-a28a-42ec-a91a-217df42c3665"),
          "GetActiveSessionByAssignmentId(global::System.Int64)"
      , assignmentId);
      }

    }
  }
}

// ==================================================================
// RepackingSessionFilterState.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Shared.RepackingSession
{

  public class RepackingSessionFilterInfo : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterInfo,
    global::Sungero.SmartProcessing.IRepackingSessionFilterInfo
  {
  }

  public class RepackingSessionFilterState : global::Sungero.CoreEntities.Shared.DatabookEntry.DatabookEntryFilterState,
    global::Sungero.SmartProcessing.IRepackingSessionFilterState
  {



    public new Sungero.SmartProcessing.IRepackingSessionFilterInfo Info
    {
      get
      {
        return (Sungero.SmartProcessing.IRepackingSessionFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.SmartProcessing.Shared.RepackingSession.RepackingSessionFilterInfo();
    }

  }
}

// ==================================================================
// RepackingSessionSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class RepackingSessionSharedPublicFunctions : global::Sungero.SmartProcessing.Shared.IRepackingSessionSharedPublicFunctions
  {
  }
}
