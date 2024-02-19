
// ==================================================================
// ExtractTextQueueItem.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
    public class ExtractTextQueueItemFilter<T> :
      global::Sungero.Domain.EntityFilterBase<T>
      where T : class, global::Sungero.SmartProcessing.IExtractTextQueueItem
    {
      protected new global::Sungero.SmartProcessing.IExtractTextQueueItemFilterState Filter { get; private set; }

      private global::Sungero.SmartProcessing.IExtractTextQueueItemFilterState filter
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

      public ExtractTextQueueItemFilter(global::Sungero.SmartProcessing.IExtractTextQueueItemFilterState filter)
      : base()
      {
        this.Filter = filter;
      }

      protected ExtractTextQueueItemFilter()
      {
      }
    }
      public class ExtractTextQueueItemUiFilter<T> :
        global::Sungero.Domain.EntityUiFilterBase<T>
        where T : class, global::Sungero.SmartProcessing.IExtractTextQueueItem
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class ExtractTextQueueItemSearchDialogModel : global::Sungero.CoreEntities.Server.DatabookEntrySearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }



                  public virtual global::System.String Name { get; protected set; }
                  public virtual global::System.Int64? DocumentId { get; protected set; }
                  public virtual global::System.Int32? ArioTaskId { get; protected set; }
                  public virtual global::System.Int32? DocumentVersionNumber { get; protected set; }


                  public virtual global::System.Collections.Generic.IEnumerable<Sungero.Core.Enumeration> ProcessingStatus { get; protected set; }
                  public virtual global::System.Collections.Generic.IEnumerable<CommonLibrary.DateRangeValue> Created { get; protected set; }


        }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.SmartProcessing.Server.ExtractTextQueueItemFilter<global::Sungero.SmartProcessing.IExtractTextQueueItem>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.SmartProcessing.Server.ExtractTextQueueItemUiFilter<global::Sungero.SmartProcessing.IExtractTextQueueItem>))]

  public class ExtractTextQueueItem :
    global::Sungero.CoreEntities.Server.DatabookEntry, global::Sungero.SmartProcessing.IExtractTextQueueItem
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("79ed70e3-bd59-432d-8671-ef6399721f2b");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.SmartProcessing.Server.ExtractTextQueueItem.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.SmartProcessing.IExtractTextQueueItem, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.SmartProcessing.IExtractTextQueueItemState State
    {
      get { return (global::Sungero.SmartProcessing.IExtractTextQueueItemState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.SmartProcessing.Shared.ExtractTextQueueItemState(this);
    }

    public new virtual global::Sungero.SmartProcessing.IExtractTextQueueItemInfo Info
    {
      get { return (global::Sungero.SmartProcessing.IExtractTextQueueItemInfo)base.Info; }
    }

    public new virtual global::Sungero.SmartProcessing.IExtractTextQueueItemAccessRights AccessRights
    {
      get { return (global::Sungero.SmartProcessing.IExtractTextQueueItemAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.SmartProcessing.Server.ExtractTextQueueItemAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.SmartProcessing.Server.ExtractTextQueueItemFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.SmartProcessing.Shared.ExtractTextQueueItemFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.SmartProcessing.ExtractTextQueueItemServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.SmartProcessing.ExtractTextQueueItemSharedHandlers(this);
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
    private global::System.Int32? _ArioTaskId;
    public virtual global::System.Int32? ArioTaskId
    {
      get
      {
        return this._ArioTaskId;
      }

      set
      {
        this.SetPropertyValue("ArioTaskId", this._ArioTaskId, value, (propertyValue) => { this._ArioTaskId = propertyValue; }, this.ArioTaskIdChangedHandler);
      }
    }
    private global::System.Int32? _DocumentVersionNumber;
    public virtual global::System.Int32? DocumentVersionNumber
    {
      get
      {
        return this._DocumentVersionNumber;
      }

      set
      {
        this.SetPropertyValue("DocumentVersionNumber", this._DocumentVersionNumber, value, (propertyValue) => { this._DocumentVersionNumber = propertyValue; }, this.DocumentVersionNumberChangedHandler);
      }
    }
    private global::System.DateTime? _Created;
    public virtual global::System.DateTime? Created
    {
      get
      {
        return this._Created;
      }

      set
      {
        this.SetPropertyValue("Created", this._Created, value, (propertyValue) => { this._Created = propertyValue; }, this.CreatedChangedHandler);
      }
    }





    private global::Sungero.Domain.Shared.IBinaryData _ExtractedText;

    [global::Sungero.Domain.Shared.DoNotSavePreviousValue]
    public virtual global::Sungero.Domain.Shared.IBinaryData ExtractedText
    {
      get { return this._ExtractedText; }
      set { this.SetComponentPropertyValue("ExtractedText", this._ExtractedText, value, (propertyValue) => { this._ExtractedText = propertyValue; }, this.ExtractedTextChangedHandler, this.InitExtractedText); }
    }


    private static global::Sungero.Domain.Shared.EnumerationItems _ProcessingStatusItems = new global::Sungero.Domain.Shared.EnumerationItems(
      null,
      typeof(global::Sungero.SmartProcessing.ExtractTextQueueItem.ProcessingStatus),
      typeof(global::Sungero.SmartProcessing.Server.ExtractTextQueueItem),
      "ProcessingStatus");

    public static global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusItems
    {
      get { return global::Sungero.SmartProcessing.Server.ExtractTextQueueItem._ProcessingStatusItems; }
    }

    public virtual global::Sungero.Domain.Shared.EnumerationItems ProcessingStatusAllowedItems
    {
      get { return global::Sungero.SmartProcessing.Server.ExtractTextQueueItem.ProcessingStatusItems; }
    }

    private global::Sungero.Core.Enumeration? _ProcessingStatus;

    public virtual global::Sungero.Core.Enumeration? ProcessingStatus
    {
      get { return this._ProcessingStatus; }
      set { this.SetEnumPropertyValue("ProcessingStatus", this._ProcessingStatus, value, (propertyValue) => { this._ProcessingStatus = propertyValue; }, this.ProcessingStatusChangedHandler, this.ProcessingStatusAllowedItems); }
    }





    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.SmartProcessing.ExtractTextQueueItemCreatingFromServerHandler", new object[] { (global::Sungero.SmartProcessing.IExtractTextQueueItem)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.SmartProcessing.ExtractTextQueueItemCreatingFromServerHandler((global::Sungero.SmartProcessing.IExtractTextQueueItem)entitySource, this.Info);
    }

    #region Framework events

    protected void NameChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.StringPropertyChangedEventArgs(this.State.Properties.Name, this.Name, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).NameChanged(args);
    }

    protected void DocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.DocumentId, this.DocumentId, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).DocumentIdChanged(args);
    }

    protected void ArioTaskIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.ArioTaskId, this.ArioTaskId, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).ArioTaskIdChanged(args);
    }

    protected void ProcessingStatusChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.EnumerationPropertyChangedEventArgs(this.State.Properties.ProcessingStatus, this.ProcessingStatus, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).ProcessingStatusChanged(args);
    }

    protected void ExtractedTextChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.BinaryDataPropertyChangedEventArgs(this.State.Properties.ExtractedText, this.ExtractedText, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).ExtractedTextChanged(args);
    }

    protected void DocumentVersionNumberChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.IntegerPropertyChangedEventArgs(this.State.Properties.DocumentVersionNumber, this.DocumentVersionNumber, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).DocumentVersionNumberChanged(args);
    }

    protected void CreatedChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.DateTimePropertyChangedEventArgs(this.State.Properties.Created, this.Created, this);
     ((global::Sungero.SmartProcessing.IExtractTextQueueItemSharedHandlers)this.SharedHandlers).CreatedChanged(args);
    }



    #endregion

    private void InitExtractedText(global::Sungero.Domain.Shared.IBinaryData value)
    {
      if (value != null)
      {
        this._ExtractedText = (global::Sungero.Domain.Shared.IBinaryData)value.Clone();
        this._ExtractedText.RootEntity = this;
        ((global::Sungero.Domain.Shared.IExtendedBinaryData)this._ExtractedText).PropertyName = "ExtractedText";
        ((global::Sungero.Domain.Shared.IInternalComponent)this._ExtractedText).ComponentChanged += (sender, e) =>
        {
          if (this.IsPropertyChangedHandlerEnabled && this.IsPropertyChangedAppliedHandlerEnabled("ExtractedText"))
            this.ExtractedTextChangedHandler();
          this.OnComponentPropertyChanged("ExtractedText", e.PropertyNames);
        };
        ((global::Sungero.Domain.Shared.IInternalComponent)this._ExtractedText).ComponentChanging += (sender, e) =>
          this.OnComponentPropertyChanging("ExtractedText", e.PropertyName);
      }
      else
        this._ExtractedText = null;
    }


    public ExtractTextQueueItem()
    {
      this.InitExtractedText(new global::Sungero.Domain.BinaryData());

    }

  }
}

// ==================================================================
// ExtractTextQueueItemHandlers.g.cs
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

  public partial class ExtractTextQueueItemFilteringServerHandler<T>
    : global::Sungero.Domain.EntityFilteringServerHandler<T>  
    where T : class, global::Sungero.SmartProcessing.IExtractTextQueueItem
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected new global::Sungero.SmartProcessing.IExtractTextQueueItemFilterState Filter { get; private set; }

    private global::Sungero.SmartProcessing.IExtractTextQueueItemFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public ExtractTextQueueItemFilteringServerHandler(global::Sungero.SmartProcessing.IExtractTextQueueItemFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected ExtractTextQueueItemFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      return query;
    }


  }

  public partial class ExtractTextQueueItemUiFilteringServerHandler<T>
    : global::Sungero.Domain.EntityUiFilteringServerHandler<T>
    where T : class, global::Sungero.SmartProcessing.IExtractTextQueueItem
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class ExtractTextQueueItemSearchDialogServerHandler : global::Sungero.CoreEntities.DatabookEntrySearchDialogServerHandler
   {
     private global::Sungero.SmartProcessing.Server.ExtractTextQueueItemSearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.SmartProcessing.Server.ExtractTextQueueItemSearchDialogModel)this.Dialog;
       }
     }

     public ExtractTextQueueItemSearchDialogServerHandler(global::Sungero.SmartProcessing.Server.ExtractTextQueueItemSearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class ExtractTextQueueItemServerHandlers : global::Sungero.CoreEntities.DatabookEntryServerHandlers
  {
    private global::Sungero.SmartProcessing.IExtractTextQueueItem _obj
    {
      get { return (global::Sungero.SmartProcessing.IExtractTextQueueItem)this.Entity; }
    }

    public ExtractTextQueueItemServerHandlers(global::Sungero.SmartProcessing.IExtractTextQueueItem entity)
      : base(entity)
    {
    }
  }

  public partial class ExtractTextQueueItemCreatingFromServerHandler : global::Sungero.CoreEntities.DatabookEntryCreatingFromServerHandler
  {
    private global::Sungero.SmartProcessing.IExtractTextQueueItem _source
    {
      get { return (global::Sungero.SmartProcessing.IExtractTextQueueItem)this.Source; }
    }

    private global::Sungero.SmartProcessing.IExtractTextQueueItemInfo _info
    {
      get { return (global::Sungero.SmartProcessing.IExtractTextQueueItemInfo)this._Info; }
    }

    public ExtractTextQueueItemCreatingFromServerHandler(global::Sungero.SmartProcessing.IExtractTextQueueItem source, global::Sungero.SmartProcessing.IExtractTextQueueItemInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// ExtractTextQueueItemEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
}

// ==================================================================
// ExtractTextQueueItemAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
  public class ExtractTextQueueItemAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryAccessRights, Sungero.SmartProcessing.IExtractTextQueueItemAccessRights
  {

    public ExtractTextQueueItemAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class ExtractTextQueueItemTypeAccessRights : 
    Sungero.CoreEntities.Server.DatabookEntryTypeAccessRights, Sungero.SmartProcessing.IExtractTextQueueItemAccessRights
  {

    public ExtractTextQueueItemTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// ExtractTextQueueItemRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
    public class ExtractTextQueueItemRepositoryImplementer<T> : 
      global::Sungero.Domain.RepositoryImplementer<T>,
      global::Sungero.SmartProcessing.IExtractTextQueueItemRepositoryImplementer<T>
      where T : global::Sungero.SmartProcessing.IExtractTextQueueItem 
    {
       public new global::Sungero.SmartProcessing.IExtractTextQueueItemAccessRights AccessRights
       {
          get { return (global::Sungero.SmartProcessing.IExtractTextQueueItemAccessRights)base.AccessRights; }
       }

       public new global::Sungero.SmartProcessing.IExtractTextQueueItemInfo Info
       {
          get { return (global::Sungero.SmartProcessing.IExtractTextQueueItemInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.SmartProcessing.Server.ExtractTextQueueItemTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// ExtractTextQueueItemPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
}

// ==================================================================
// ExtractTextQueueItemServerFunctions.g.cs
// ==================================================================

namespace Sungero.SmartProcessing.Server
{
  public partial class ExtractTextQueueItemFunctions : global::Sungero.CoreEntities.Server.DatabookEntryFunctions
  {
    private global::Sungero.SmartProcessing.IExtractTextQueueItem _obj
    {
      get { return (global::Sungero.SmartProcessing.IExtractTextQueueItem)this.Entity; }
    }

    public ExtractTextQueueItemFunctions(global::Sungero.SmartProcessing.IExtractTextQueueItem entity) : base(entity) { }
  }
}

// ==================================================================
// ExtractTextQueueItemFunctions.g.cs
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
  internal static class ExtractTextQueueItem
  {
    /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ExtractTextQueueItemFunctions" />
    internal static  void ProcessTextExtractionTask(global::Sungero.SmartProcessing.IExtractTextQueueItem extractTextQueueItem, ArioExtensions.ArioConnector arioConnector)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)extractTextQueueItem).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ProcessTextExtractionTask", new System.Type[] { typeof(ArioExtensions.ArioConnector) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { arioConnector });
    }
    /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ExtractTextQueueItemFunctions" />
    internal static  void SendDocumentForTextExtraction(global::Sungero.SmartProcessing.IExtractTextQueueItem extractTextQueueItem, ArioExtensions.ArioConnector arioConnector)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)extractTextQueueItem).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SendDocumentForTextExtraction", new System.Type[] { typeof(ArioExtensions.ArioConnector) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { arioConnector });
    }
    /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ExtractTextQueueItemFunctions" />
    internal static  System.Byte[] GetDocumentBody(global::Sungero.SmartProcessing.IExtractTextQueueItem extractTextQueueItem)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)extractTextQueueItem).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentBody", new System.Type[] {  });
      return (System.Byte[])global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.SmartProcessing.Server" type="Sungero.SmartProcessing.Server.ExtractTextQueueItemFunctions" />
    internal static  void SetProcessedStatus(global::Sungero.SmartProcessing.IExtractTextQueueItem extractTextQueueItem, global::System.Nullable<global::Sungero.Core.Enumeration> status)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)extractTextQueueItem).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("SetProcessedStatus", new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { status });
    }

  }
}

// ==================================================================
// ExtractTextQueueItemServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
  public class ExtractTextQueueItemServerPublicFunctions : global::Sungero.SmartProcessing.Server.IExtractTextQueueItemServerPublicFunctions
  {
  }
}

// ==================================================================
// ExtractTextQueueItemQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Queries
{
  public class ExtractTextQueueItem
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.SmartProcessing.Server.ExtractTextQueueItem.ExtractTextQueueItemQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}